namespace HeartOfDarkness.Client.Store;

public record CreateNewGameResultAction(
	Game Game,
	GameDefinition GameDefinition,
	IEnumerable<Game> Games
);
