using Blazored.LocalStorage;
using Fluxor.Blazor.Web.Middlewares.Routing;

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
		List<SavedGame>? games = await _storage.GetItemAsync<List<SavedGame>?>( "games", CancellationToken.None );
		SavedGame savedGame = games?.First( g => g.Id == action.Id ) ?? throw new InvalidOperationException();
		Game game = await _gameFactory.CreateFromSavedGameAsync( savedGame, CancellationToken.None );
		dispatcher.Dispatch( new LoadSavedGameResultAction( game ) );
	}

	[EffectMethod]
	public static Task HandleLoadSavedGameResultAction(
		LoadSavedGameResultAction action,
		IDispatcher dispatcher
	) {
		if( string.IsNullOrWhiteSpace( action.Game.Player.PortOfEntry ) ) {
			dispatcher.Dispatch( new GoAction( "/portofentry" ) );
		} else {
			dispatcher.Dispatch( new GoAction( "/map" ) );
		}
		return Task.CompletedTask;
	}
}
