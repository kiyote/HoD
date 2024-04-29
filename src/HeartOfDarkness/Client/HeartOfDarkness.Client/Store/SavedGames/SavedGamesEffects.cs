using Blazored.LocalStorage;
using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Store.SavedGames;

public class SavedGamesEffects {

	private readonly ILocalStorageService _storage;
	private readonly ISavedGameFactory _savedGameFactory;

	public SavedGamesEffects(
		ILocalStorageService storage,
		ISavedGameFactory savedGameFactory
	) {
		_storage = storage;
		_savedGameFactory = savedGameFactory;
	}

	[EffectMethod]
	public async Task HandleEnumerateSavedGamesAction(
		EnumerateSavedGamesAction _,
		IDispatcher dispatcher
	) {
		List<SavedGame>? games = await _storage.GetItemAsync<List<SavedGame>?>( "games" ).ConfigureAwait( false );
		dispatcher.Dispatch( new EnumerateSavedGamesResultAction( games ?? [] ) );
	}

	[EffectMethod]
	public async Task HandleDeleteSavedGameAction(
		DeleteSavedGameAction action,
		IDispatcher dispatcher
	) {
		List<SavedGame> games = await _storage.GetItemAsync<List<SavedGame>?>( "games" ) ?? [];
		games = games.Where( g => g.Id != action.Id ).ToList();
		await _storage.SetItemAsync( "games", games );
		dispatcher.Dispatch( new DeleteSavedGameResultAction( games ) );
	}

	[EffectMethod]
	public async Task HandleCreateNewGameAction(
		CreateNewGameAction action,
		IDispatcher dispatcher
	) {
		List<SavedGame> games = await _storage.GetItemAsync<List<SavedGame>?>( "games" ) ?? [];
		SavedGame savedGame = _savedGameFactory.CreateFromGame( action.Game );
		games.Add( savedGame );
		await _storage.SetItemAsync( "games", games );
		dispatcher.Dispatch( new CreateNewGameResultAction( savedGame, games ) );
	}

	[EffectMethod]
	public static Task HandleCreateNewGameResultAction(
		CreateNewGameResultAction action,
		IDispatcher dispatcher
	) {
		dispatcher.Dispatch( new LoadSavedGameAction( action.Game.Id ) );
		return Task.CompletedTask;
	}
}
