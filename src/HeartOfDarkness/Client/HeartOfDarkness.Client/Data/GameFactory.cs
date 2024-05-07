namespace HeartOfDarkness.Client.Data;

internal sealed class GameFactory : IGameFactory {

	private readonly IMapDefinitionProvider _mapDefinitionFactory;
	private readonly IMapStateFactory _mapStateFactory;

	public GameFactory(
		IMapDefinitionProvider mapDefinitionFactory,
		IMapStateFactory mapStateFactory
	) {
		_mapDefinitionFactory = mapDefinitionFactory;
		_mapStateFactory = mapStateFactory;
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
		MapDefinition mapDefinition = await _mapDefinitionFactory.GetAsync(
			cancellationToken
		);
		MapState mapState = await _mapStateFactory.CreateAsync(
			mapDefinition,
			CancellationToken.None
		);
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
