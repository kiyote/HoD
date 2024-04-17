namespace HeartOfDarkness.Client.Store.SavedGames;

public record AddSavedGameResultAction(
	IEnumerable<Game> Games
);
