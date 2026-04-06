using HeartOfDarkness.Client.Data;
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

	[Inject]
	public required IPlayerColourDefinitionProvider PlayerColourDefinitionProvider { get; init; }

	protected DisplayState PageState { get; set; } = DisplayState.Map;

	protected IList<PlayerColourDefinition> PlayerColourDefinitions { get; set; } = [];

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if( firstRender ) {
			// TODO: This is bad and is here purely for visualization purposes while developing
			PlayerColourDefinitions = await PlayerColourDefinitionProvider.GetAsync( CancellationToken.None );
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
