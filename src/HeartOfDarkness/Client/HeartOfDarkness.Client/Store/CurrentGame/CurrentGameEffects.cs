using Blazored.LocalStorage;
using Fluxor.Blazor.Web.Middlewares.Routing;
using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Store.CurrentGame;

public class CurrentGameEffects {

	private readonly ILocalStorageService _storage;
	private readonly IGameFactory _gameFactory;

	public CurrentGameEffects(
		ILocalStorageService storage,
		IGameFactory gameFactory
	) {
		_storage = storage;
		_gameFactory = gameFactory;
	}

	[EffectMethod]
	public async Task HandleLoadSavedGameAction(
		LoadSavedGameAction action,
		IDispatcher dispatcher
	) {
		List<Game>? games = await _storage.GetItemAsync<List<Game>?>( "games", CancellationToken.None );
		Game savedGame = games?.First( g => g.Id == action.Id ) ?? throw new InvalidOperationException();
		Game game = await _gameFactory.CreateFromSavedGameAsync( savedGame, CancellationToken.None );
		dispatcher.Dispatch( new LoadSavedGameResultAction( game ) );
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
