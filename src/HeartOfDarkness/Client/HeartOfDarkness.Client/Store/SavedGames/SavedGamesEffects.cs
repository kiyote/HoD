using Blazored.LocalStorage;
using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Store.SavedGames;

public class SavedGamesEffects {

	private readonly ILocalStorageService _storage;
	private readonly IGameFactory _gameFactory;

	public SavedGamesEffects(
		ILocalStorageService storage,
		IGameFactory gameFactory
	) {
		_storage = storage;
		_gameFactory = gameFactory;
	}

	[EffectMethod]
	public async Task HandleEnumerateSavedGamesAction(
		EnumerateSavedGamesAction _,
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
		List<Game> games = await _storage.GetItemAsync<List<Game>?>( "games" ) ?? [];
		games = games.Where( g => g.Id != action.Id ).ToList();
		await _storage.SetItemAsync( "games", games );
		dispatcher.Dispatch( new DeleteSavedGameResultAction( games ) );
	}

	[EffectMethod]
	public async Task HandleCreateNewGameAction(
		CreateNewGameAction action,
		IDispatcher dispatcher
	) {
		List<Game> games = await _storage.GetItemAsync<List<Game>?>( "games" ) ?? [];
		Game savedGame = await _gameFactory.CreateNewAsync( action.Game, CancellationToken.None );
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
