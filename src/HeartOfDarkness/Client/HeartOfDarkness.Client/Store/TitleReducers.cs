namespace HeartOfDarkness.Client.Store;

public static class TitleReducers {

	[ReducerMethod]
	public static TitleState ReduceSetTitleAction(
		TitleState state,
		SetTitleAction action
	) => state with {
		Title = action.Title
	};
}
