namespace HeartOfDarkness.Client.Store.CurrentGame;

public record CurrentGameState(
	bool IsLoading,
	Game Game
);
