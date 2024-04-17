using Blazored.LocalStorage;

namespace HeartOfDarkness.Client;


public sealed class GameState {

	private readonly ILocalStorageService _storage;

	public GameState(
		ILocalStorageService storage
	) {
		_storage = storage;
	}

	public IEnumerable<Game> Games { get; private set; } = [];

	public Game Game { get; private set; } = default!;

	public string Title { get; private set; } = "";

	public void SetTite(
		string title
	) {
		Title = title;
	}

	public void AddGame(
		Game game
	) {
		Games = Games.Append( game );
	}

	public void LoadGame(
		Game game
	) {
		Game = game;
	}

	public void DeleteGame(
		Game game
	) {
		Console.WriteLine( $"Count: {Games.Count()}" );
		Games = Games.Except( [game] );
		Console.WriteLine( $"Count: {Games.Count()}" );
	}

	public async Task LoadAsync() {
		List<Game>? games = await _storage.GetItemAsync<List<Game>?>( "games" ).ConfigureAwait( false );
		Games = games ?? [];
	}

	public async Task SaveAsync() {
		await _storage.SetItemAsync( "games", Games ).ConfigureAwait( false );
	}
}
