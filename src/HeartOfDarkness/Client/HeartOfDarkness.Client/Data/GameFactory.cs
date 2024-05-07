namespace HeartOfDarkness.Client.Data;

internal sealed class GameFactory : IGameFactory {

	private readonly IMapDefinitionProvider _mapDefinitionFactory;
	private readonly IMapStateFactory _mapStateFactory;
	private readonly IPlayerColourDefinitionProvider _playerColourDefinitionProvider;

	public GameFactory(
		IMapDefinitionProvider mapDefinitionFactory,
		IMapStateFactory mapStateFactory,
		IPlayerColourDefinitionProvider playerColourDefinitionProvider
	) {
		_mapDefinitionFactory = mapDefinitionFactory;
		_mapStateFactory = mapStateFactory;
		_playerColourDefinitionProvider = playerColourDefinitionProvider;
	}

	async Task<Game> IGameFactory.CreateAsync(
		CancellationToken cancellationToken
	) {
		MapDefinition mapDefinition = await _mapDefinitionFactory.GetAsync(
			cancellationToken
		);
		MapState mapState = await _mapStateFactory.CreateAsync(
			mapDefinition,
			CancellationToken.None
		);
		return new Game(
			Guid.NewGuid(),
			Player.None,
			mapState,
			mapDefinition
		);
	}

	async Task<Game> IGameFactory.CreateFromSavedGameAsync(
		Game savedGame,
		CancellationToken cancellationToken
	) {
		MapDefinition mapDefinition = await _mapDefinitionFactory.GetAsync(
			cancellationToken
		);

		return savedGame with {
			MapDefinition = mapDefinition
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
		IList<PlayerColourDefinition> playerColourDefinitions = await _playerColourDefinitionProvider.GetAsync( CancellationToken.None );
		PlayerColourDefinition colourDefinition = playerColourDefinitions.First( d => d.Id == newGame.Colour );
		mapState[newGame.PortOfEntry] = mapState[newGame.PortOfEntry] with { Token = colourDefinition.Image };
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
			mapDefinition
		);
	}
}
