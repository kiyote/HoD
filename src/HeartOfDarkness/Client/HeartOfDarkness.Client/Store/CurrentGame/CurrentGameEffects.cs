using Blazored.LocalStorage;
using Fluxor.Blazor.Web.Middlewares.Routing;
using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Store.CurrentGame;

public class CurrentGameEffects {

	private readonly ILocalStorageService _storage;
	private readonly IGameDefinitionFactory _gameDefinitionFactory;

	public CurrentGameEffects(
		ILocalStorageService storage,
		IGameDefinitionFactory gameDefinitionFactory
	) {
		_storage = storage;
		_gameDefinitionFactory = gameDefinitionFactory;
	}

	[EffectMethod]
	public async Task HandleLoadSavedGameAction(
		LoadSavedGameAction action,
		IDispatcher dispatcher
	) {
		List<Game>? games = await _storage.GetItemAsync<List<Game>?>( "games", CancellationToken.None );
		Game savedGame = games?.FirstOrDefault( g => g.Id == action.Id ) ?? throw new InvalidOperationException();
		GameDefinition gameDefinition = await _gameDefinitionFactory.CreateAsync( CancellationToken.None );
		dispatcher.Dispatch( new LoadSavedGameResultAction( savedGame, gameDefinition ) );
	}

	[EffectMethod]
	public static Task HandleLoadSavedGameResultAction(
		LoadSavedGameResultAction _,
		IDispatcher dispatcher
	) {
		dispatcher.Dispatch( new GoAction( "/play" ) );
		return Task.CompletedTask;
	}
}
