namespace HeartOfDarkness.Client.Store.SavedGames;

public record DeleteSavedGameResultAction(
	IEnumerable<Game> Games
);
