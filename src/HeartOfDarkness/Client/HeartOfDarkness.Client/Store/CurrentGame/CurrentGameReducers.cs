namespace HeartOfDarkness.Client.Store.CurrentGame;

public static class CurrentGameReducers {

	[ReducerMethod]
	public static CurrentGameState ReduceLoadSavedGameResultAction(
		CurrentGameState state,
		LoadSavedGameResultAction action
	) =>
		state with { IsLoading = false, Game = action.Game };
}
