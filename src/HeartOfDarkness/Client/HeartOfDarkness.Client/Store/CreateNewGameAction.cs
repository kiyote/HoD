namespace HeartOfDarkness.Client.Store;

public record CreateNewGameAction(
	GameDefinition GameDefinition,
	NewGame Game
);
