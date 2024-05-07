namespace HeartOfDarkness.Client.Data;

public interface IGameFactory {

	Task<Game> CreateAsync(
		CancellationToken cancellationToken
	);

	Task<Game> CreateFromSavedGameAsync(
		Game savedGame,
		CancellationToken cancellationToken
	);

	Task<Game> CreateNewAsync(
		NewGame newGame,
		CancellationToken cancellationToken
	);

}
