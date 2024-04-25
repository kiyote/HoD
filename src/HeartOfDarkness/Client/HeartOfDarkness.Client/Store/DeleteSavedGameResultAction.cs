namespace HeartOfDarkness.Client.Store;

public record DeleteSavedGameResultAction(
	IEnumerable<SavedGame> Games
);
