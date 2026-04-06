using HeartOfDarkness.Client.Store.CurrentGame;

namespace HeartOfDarkness.Client.Pages.PlayGame;

public class PlayGamePageBase : ComponentBase {

	protected enum DisplayState {
		Unknown,
		Map,
		Matrix
	}

	[Inject]
	public required IState<CurrentGameState> GameState { get; init; }

	protected DisplayState PageState { get; set; } = DisplayState.Map;

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if( firstRender ) {
			// TODO: This is bad and is here purely for visualization purposes while developing
			string playerRegionId = GameState.Value.Game.Player.RegionId;
			RegionDefinition playerRegion = GameState.Value.Game.MapDefinition[playerRegionId];
			foreach( string regionId in playerRegion.AdjacentRegionIds ) {
				RegionState current = GameState.Value.Game.MapState.Regions[regionId];
				GameState.Value.Game.MapState.Regions[regionId] = current with { Style = RegionStyle.Highlighted };
			}
			StateHasChanged();
		}
	}

	protected void ToggleDisplay() {
		if( PageState == DisplayState.Map ) {
			PageState = DisplayState.Matrix;
		} else {
			PageState = DisplayState.Map;
		}
	}
}
