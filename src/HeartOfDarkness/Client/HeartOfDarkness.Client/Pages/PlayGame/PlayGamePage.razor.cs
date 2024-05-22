using HeartOfDarkness.Client.Data;
using HeartOfDarkness.Client.Store.CurrentGame;

namespace HeartOfDarkness.Client.Pages.PlayGame;

public class PlayGamePageBase: ComponentBase {

	protected enum DisplayState {
		Unknown,
		Map,
		Matrix
	}

	[Inject]
	protected IState<CurrentGameState> GameState { get; set; } = default!;

	[Inject]
	protected IPlayerColourDefinitionProvider PlayerColourDefinitionProvider { get; set; } = default!;

	protected DisplayState PageState { get; set; } = DisplayState.Map;

	protected IList<PlayerColourDefinition> PlayerColourDefinitions { get; set; } = [];

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if (firstRender) {
			PlayerColourDefinitions = await PlayerColourDefinitionProvider.GetAsync( CancellationToken.None );
			string playerRegionId = GameState.Value.Game.Player.RegionId;
			RegionDefinition playerRegion = GameState.Value.Game.MapDefinition[playerRegionId];
			foreach (string regionId in playerRegion.AdjacentRegionIds) {
				RegionState current = GameState.Value.Game.MapState.Regions[regionId];
				GameState.Value.Game.MapState.Regions[regionId] = current with { Style = RegionStyle.Highlighted };
			}
			StateHasChanged();
		}
	}
}
