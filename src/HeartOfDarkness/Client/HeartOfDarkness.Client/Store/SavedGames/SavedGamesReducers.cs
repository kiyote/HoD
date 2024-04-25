namespace HeartOfDarkness.Client.Store.SavedGames;

public static class SavedGamesReducers {

	[ReducerMethod( typeof( EnumerateSavedGamesAction ) )]
	public static SavedGamesState ReduceEnumerateSavedGamesAction(
		SavedGamesState state
	) =>
	  state with { IsLoading = true, Games = [] };

	[ReducerMethod]
	public static SavedGamesState ReduceEnumerateSavedGamesResultAction(
		SavedGamesState state,
		EnumerateSavedGamesResultAction action
	) =>
		state with { IsLoading = false, Games = action.Games };

	[ReducerMethod]
	public static SavedGamesState ReduceDeleteSavedGameResultAction(
		SavedGamesState state,
		DeleteSavedGameResultAction action
	) =>
		state with { IsLoading = false, Games = action.Games };

	[ReducerMethod]
	public static SavedGamesState ReduceAddSavedGameResultAction(
		SavedGamesState state,
		CreateNewGameResultAction action
	) =>
		state with { IsLoading = false, Games = action.Games };
}
