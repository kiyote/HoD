namespace HeartOfDarkness.Client.Pages.PortOfEntry;

public partial class PortOfEntryPage : ComponentBase {

	protected MapComponent Map { get; set; } = default!;

	private async Task OnSetInitialMapStateHandler() {
		await Map.SetRegion( RegionId.Khartoum, MapComponent.Style.Selectable );
		await Map.SetRegion( RegionId.FernandoPoo, MapComponent.Style.Selectable );
		await Map.SetRegion( RegionId.Mocambique, MapComponent.Style.Selectable );
		await Map.SetRegion( RegionId.Angola, MapComponent.Style.Selectable );
		await Map.SetRegion( RegionId.Zanzibar, MapComponent.Style.Selectable );
	}

	[System.Diagnostics.CodeAnalysis.SuppressMessage( "Performance", "CA1822:Mark members as static", Justification = "<Pending>" )]
	private Task OnRegionSelectedHandler(
		string regionId
	) {
		Console.WriteLine( regionId );
		return Task.CompletedTask;
	}
}
