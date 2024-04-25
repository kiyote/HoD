namespace HeartOfDarkness.Client.Store;

public record CreateNewGameResultAction(
	SavedGame Game,
	IEnumerable<SavedGame> Games
);
