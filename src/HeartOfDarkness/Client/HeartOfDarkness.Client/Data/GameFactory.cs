namespace HeartOfDarkness.Client.Data;

internal sealed class GameFactory : IGameFactory {

	private readonly IMapDefinitionProvider _mapDefinitionFactory;
	private readonly IMapStateFactory _mapStateFactory;
	private readonly IPlayerColourDefinitionProvider _playerColourDefinitionProvider;
	private readonly IMatrixDefinitionProvider _matrixDefinitionProvider;

	public GameFactory(
		IMapDefinitionProvider mapDefinitionFactory,
		IMapStateFactory mapStateFactory,
		IPlayerColourDefinitionProvider playerColourDefinitionProvider,
		IMatrixDefinitionProvider matrixDefinitionProvider
	) {
		_mapDefinitionFactory = mapDefinitionFactory;
		_mapStateFactory = mapStateFactory;
		_playerColourDefinitionProvider = playerColourDefinitionProvider;
		_matrixDefinitionProvider = matrixDefinitionProvider;
	}

	async Task<Game> IGameFactory.CreateFromSavedGameAsync(
		Game savedGame,
		CancellationToken cancellationToken
	) {
		IList<PlayerColourDefinition> playerColourDefinitions = await _playerColourDefinitionProvider.GetAsync( CancellationToken.None );
		PlayerColourDefinition colourDefinition = playerColourDefinitions.First( d => d.Id == savedGame.Player.ColourId );
		MapDefinition mapDefinition = await _mapDefinitionFactory.GetAsync(
			cancellationToken
		);
		MatrixDefinition matrixDefinition = await _matrixDefinitionProvider.GetAsync(
			cancellationToken
		);

		return savedGame with {
			MapDefinition = mapDefinition,
			MatrixDefinition = matrixDefinition,
			PlayerColourDefinition = colourDefinition
		};
	}

	async Task<Game> IGameFactory.CreateNewAsync(
		NewGame newGame,
		CancellationToken cancellationToken
	) {
		if (string.IsNullOrWhiteSpace(newGame.PortOfEntry)) {
			throw new ArgumentException( "PortOfEntry must not be null or whitespace.", nameof( newGame ) );
		}
		MapDefinition mapDefinition = await _mapDefinitionFactory.GetAsync(
			cancellationToken
		);
		MapState mapState = await _mapStateFactory.CreateAsync(
			mapDefinition,
			CancellationToken.None
		);
		MatrixDefinition matrixDefinition = await _matrixDefinitionProvider.GetAsync(
			cancellationToken
		);
		IList<PlayerColourDefinition> playerColourDefinitions = await _playerColourDefinitionProvider.GetAsync( CancellationToken.None );
		PlayerColourDefinition colourDefinition = playerColourDefinitions.First( d => d.Id == newGame.Colour );
		mapState[newGame.PortOfEntry] = mapState[newGame.PortOfEntry] with { Token = colourDefinition.Explorer };
		Player player = new Player(
			newGame.Colour,
			newGame.PortOfEntry ?? throw new InvalidOperationException(),
			0,
			newGame.Inventory
		);
		return new Game(
			Guid.NewGuid(),
			player,
			mapState,
			mapDefinition,
			matrixDefinition,
			colourDefinition
		);
	}
}
