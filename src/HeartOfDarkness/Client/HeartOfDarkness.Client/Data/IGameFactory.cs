namespace HeartOfDarkness.Client.Data;

public interface IGameFactory {

	Task<Game> CreateFromSavedGameAsync(
		Game savedGame,
		CancellationToken cancellationToken
	);

	Task<Game> CreateNewAsync(
		NewGame newGame,
		CancellationToken cancellationToken
	);

}
