using HeartOfDarkness.Client.Store.App;
using HeartOfDarkness.Client.Store.CurrentGame;

namespace HeartOfDarkness.Client.Pages.PortOfEntry;

public partial class PortOfEntryPage : ComponentBase {

	[Inject]
	protected IState<AppState> AppState { get; set; } = default!;

	[Inject]
	protected IState<CurrentGameState> GameState { get; set; } = default!;

	protected override Task OnInitializedAsync() {
		foreach (string regionId in GameState.Value.Game.MapDefinition.PortsOfEntry) {
			AppState.Value.Map[regionId] = AppState.Value.Map[regionId] with { Style = RegionStyle.Highlighted };
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
