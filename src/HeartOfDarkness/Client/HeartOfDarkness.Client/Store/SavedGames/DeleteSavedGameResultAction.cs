namespace HeartOfDarkness.Client.Store.SavedGames;

public record DeleteSavedGameResultAction(
	IEnumerable<SavedGame> Games
);
