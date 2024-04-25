namespace HeartOfDarkness.Client.Store.SavedGames;

public record CreateNewGameResultAction(
	SavedGame Game,
	IEnumerable<SavedGame> Games
);
