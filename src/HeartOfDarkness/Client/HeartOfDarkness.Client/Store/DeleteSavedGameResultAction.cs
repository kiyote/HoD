namespace HeartOfDarkness.Client.Store;

public record DeleteSavedGameResultAction(
	IEnumerable<Game> Games
);
