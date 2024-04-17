using Blazored.LocalStorage;
using HeartOfDarkness.Client.Store.SavedGames;

namespace HeartOfDarkness.Client.Store.CurrentGame;

public class CurrentGameEffects {

	private readonly ILocalStorageService _storage;

	public CurrentGameEffects(
		ILocalStorageService storage
	) {
		_storage = storage;
	}

	[EffectMethod]
	public async Task HandleLoadSavedGameAction(
		LoadSavedGameAction action,
		IDispatcher dispatcher
	) {
		List<Game>? games = await _storage.GetItemAsync<List<Game>?>( "games" ).ConfigureAwait( false );
		Game game = games?.First( g => g.Id == action.Id ) ?? throw new InvalidOperationException();
		dispatcher.Dispatch( new LoadSavedGameResultAction( game ) );
	}
}
