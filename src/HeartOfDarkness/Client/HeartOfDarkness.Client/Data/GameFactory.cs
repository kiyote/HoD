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
		SavedGame savedGame,
		CancellationToken cancellationToken
	) {
		MapDefinition mapDefinition = await _mapDefinitionFactory.GetAsync(
			cancellationToken
		);
		return new Game(
			savedGame.Id,
			savedGame.Player,
			mapDefinition
		);
	}
}
