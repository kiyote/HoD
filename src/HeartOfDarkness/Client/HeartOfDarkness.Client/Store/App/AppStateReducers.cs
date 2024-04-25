
using Fluxor.Blazor.Web.Middlewares.Routing;

namespace HeartOfDarkness.Client.Store.App;

public static class AppStateReducers {

	[ReducerMethod]
	public static AppState ReduceCreateNewGameAction(
		AppState state,
		CreateNewGameAction action
	) {
		MapState mapState = new MapState( action.Game.MapDefinition.Regions.ToDictionary( r => r.Id, r => new RegionState( r.Id, RegionStyle.Hidden ) ) );
		return state with { Map = mapState };
	}

	[ReducerMethod]
	public static AppState ReduceLoadSavedGameAction(
		AppState state,
		LoadSavedGameResultAction action
	) {
		MapState mapState = new MapState( action.Game.MapDefinition.Regions.ToDictionary( r => r.Id, r => new RegionState( r.Id, RegionStyle.Hidden ) ) );
		return state with { Map = mapState };
	}

	[ReducerMethod]
	public static AppState ReduceGoAction(
		AppState state,
		GoAction action
	) => state with { Page = action.NewUri };
}
