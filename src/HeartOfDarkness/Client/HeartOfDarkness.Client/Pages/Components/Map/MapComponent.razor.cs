using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages;

public class MapComponentBase : ComponentBase {

	[Parameter]
	public EventCallback<string> OnRegionSelected { get; set; }

	[Parameter, EditorRequired]
	public MapState State { get; set; } = default!;

	[Parameter, EditorRequired]
	public MapDefinition Definition { get; set; } = default!;

	protected string MapFile => Definition.Image.File;

	protected int MapWidth => Definition.Image.Width;

	protected int MapHeight => Definition.Image.Height;

	protected IEnumerable<RegionDefinition> RegionDefinitions => Definition.Regions;

	[JSInvokable]
	public async Task OnRegionSelectedHandler(
		string regionId
	) {
		await OnRegionSelected.InvokeAsync( regionId );
	}
}
