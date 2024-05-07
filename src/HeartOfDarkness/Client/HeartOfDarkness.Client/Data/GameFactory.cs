namespace HeartOfDarkness.Client.Data;

internal sealed class GameFactory : IGameFactory {

	private readonly IMapDefinitionProvider _mapDefinitionFactory;

	public GameFactory(
		IMapDefinitionProvider mapDefinitionFactory
	) {
		_mapDefinitionFactory = mapDefinitionFactory;
	}

	async Task<Game> IGameFactory.CreateAsync(
		CancellationToken cancellationToken
	) {
		MapDefinition mapDefinition = await _mapDefinitionFactory.GetAsync(
			cancellationToken
		);
		return new Game(
			Guid.NewGuid(),
			Player.None,
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
		Player player = new Player(
			newGame.Colour,
			newGame.PortOfEntry ?? throw new InvalidOperationException(),
			0,
			newGame.Inventory
		);
		return new Game(
			Guid.NewGuid(),
			player,
			mapDefinition
		);
	}
}
