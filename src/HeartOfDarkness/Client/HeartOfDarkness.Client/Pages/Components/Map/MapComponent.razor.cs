using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages;

public class MapComponentBase : ComponentBase {

	[Parameter]
	public required EventCallback<string> OnRegionSelected { get; init; }

	[Parameter, EditorRequired]
	public required MapState State { get; init; }

	[Parameter, EditorRequired]
	public required MapDefinition Definition { get; init; }

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
