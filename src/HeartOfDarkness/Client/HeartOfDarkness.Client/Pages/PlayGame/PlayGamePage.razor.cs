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

	protected Game Game => GameState.Value.Game;

	protected GameDefinition GameDefinition => GameState.Value.GameDefinition;

	protected PlayerColourDefinition PlayerColourDefinition => GameDefinition.PlayerColourDefinitions.First( pcd => pcd.Id == GameState.Value.Game.Player.ColourId );

	protected RegionDefinition PlayerRegionDefinition => GameDefinition.MapDefinition.Regions.First( r => r.Id == GameState.Value.Game.Player.RegionId );

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if( firstRender ) {
			if( Game.Phase == GamePhase.Map ) {
				PageState = DisplayState.Map;
			} else if( Game.Phase == GamePhase.Matrix ) {
				PageState = DisplayState.Matrix;
			}


			// TODO: This is bad and is here purely for visualization purposes while developing
			string playerRegionId = GameState.Value.Game.Player.RegionId;
			RegionDefinition playerRegion = GameDefinition.MapDefinition[playerRegionId];
			foreach( string regionId in playerRegion.AdjacentRegionIds ) {
				RegionState current = GameState.Value.Game.MapState.Regions[regionId];
				GameState.Value.Game.MapState.Regions[regionId] = current with { Style = RegionStyle.Highlighted };
			}
			StateHasChanged();
		}
	}
}
