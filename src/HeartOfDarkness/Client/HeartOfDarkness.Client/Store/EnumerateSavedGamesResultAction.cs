namespace HeartOfDarkness.Client.Store;

public record EnumerateSavedGamesResultAction(
	IEnumerable<Game> Games
) {
}
