namespace HeartOfDarkness.Client.Model;

public interface IGameFactory {

	Task<Game> CreateAsync(
		CancellationToken cancellationToken
	);

	Task<Game> CreateFromSavedGameAsync(
		SavedGame savedGame,
		CancellationToken cancellationToken
	);

}
