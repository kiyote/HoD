namespace HeartOfDarkness.Client.Store;

public record CreateNewGameResultAction(
	Game Game,
	IEnumerable<Game> Games
);
