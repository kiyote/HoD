namespace HeartOfDarkness.Client.Store;

public record EnumerateSavedGamesResultAction(
	IEnumerable<SavedGame> Games
) {
}
