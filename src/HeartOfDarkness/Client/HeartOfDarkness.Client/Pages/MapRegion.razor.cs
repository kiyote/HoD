namespace HeartOfDarkness.Client.Pages;

public partial class MapRegion: ComponentBase {

	[Parameter]
	public RegionDefinition Definition { get; set; } = default!;

	[Parameter]
	public string FinalClass { get; set; } = "";

	protected string Id => Definition.Id;

	protected string Shape => Definition.Shape;

	[Parameter]
	public EventCallback<string> OnRegionSelected { get; set; }

	protected async Task OnClickHandler(
		string regionId
	) {
		await OnRegionSelected.InvokeAsync( regionId );
	}
}
