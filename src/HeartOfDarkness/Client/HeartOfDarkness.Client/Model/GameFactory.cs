using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Model;

internal sealed class GameFactory: IGameFactory {

	private readonly IMapDefinitionFactory _mapDefinitionFactory;

	public GameFactory(
		IMapDefinitionFactory mapDefinitionFactory
	) {
		_mapDefinitionFactory = mapDefinitionFactory;
	}

	async Task<Game> IGameFactory.CreateAsync(
		CancellationToken cancellationToken
	) {
		MapDefinition mapDefinition = await _mapDefinitionFactory.CreateAsync(
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
		MapDefinition mapDefinition = await _mapDefinitionFactory.CreateAsync(
			cancellationToken
		);
		return new Game(
			savedGame.Id,
			savedGame.Player,
			mapDefinition
		);
	}
}
