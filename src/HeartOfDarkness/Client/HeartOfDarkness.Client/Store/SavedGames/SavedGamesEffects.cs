using Blazored.LocalStorage;

namespace HeartOfDarkness.Client.Store.SavedGames;

public class SavedGamesEffects {

	private readonly ILocalStorageService _storage;

	public SavedGamesEffects(
		ILocalStorageService storage
	) {
		_storage = storage;
	}

	[EffectMethod( typeof( EnumerateSavedGamesAction ) )]
	public async Task HandleEnumerateSavedGamesAction(
		IDispatcher dispatcher
	) {
		List<Game>? games = await _storage.GetItemAsync<List<Game>?>( "games" ).ConfigureAwait( false );
		dispatcher.Dispatch( new EnumerateSavedGamesResultAction( games ?? [] ) );
	}

	[EffectMethod]
	public async Task HandleDeleteSavedGameAction(
		DeleteSavedGameAction action,
		IDispatcher dispatcher
	) {
		List<Game> games = await _storage.GetItemAsync<List<Game>?>( "games" ).ConfigureAwait( false ) ?? [];
		games = games.Where( g => g.Id != action.Id ).ToList();
		await _storage.SetItemAsync( "games", games ).ConfigureAwait( false );
		dispatcher.Dispatch( new DeleteSavedGameResultAction( games ) );
	}

	[EffectMethod]
	public async Task HandleAddSavedGameAction(
		AddSavedGameAction action,
		IDispatcher dispatcher
	) {
		List<Game> games = await _storage.GetItemAsync<List<Game>?>( "games" ).ConfigureAwait( false ) ?? [];
		games.Add( action.Game );
		await _storage.SetItemAsync( "games", games ).ConfigureAwait( false );
		dispatcher.Dispatch( new AddSavedGameResultAction( games ) );
	}
}
