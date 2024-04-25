using HeartOfDarkness.Client.Store.CurrentGame;
using HeartOfDarkness.Client.Store.Map;

namespace HeartOfDarkness.Client.Pages.PortOfEntry;

public partial class PortOfEntryPage : ComponentBase {

	[Inject]
	protected IState<MapState> MapState { get; set; } = default!;

	[Inject]
	protected IState<CurrentGameState> GameState { get; set; } = default!;

	protected override Task OnInitializedAsync() {
		foreach (string regionId in GameState.Value.Game.MapDefinition.PortsOfEntry) {
			MapState.Value[regionId] = MapState.Value[regionId] with { Style = RegionStyle.Highlighted };
		}
		return base.OnInitializedAsync();
	}

	[System.Diagnostics.CodeAnalysis.SuppressMessage( "Performance", "CA1822:Mark members as static", Justification = "<Pending>" )]
	private Task OnRegionSelectedHandler(
		string regionId
	) {
		Console.WriteLine( regionId );
		return Task.CompletedTask;
	}
}
