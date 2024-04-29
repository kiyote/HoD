using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages;

public class MapComponentBase : ComponentBase {

	[Parameter]
	public EventCallback<string> OnRegionSelected { get; set; }

	[Parameter, EditorRequired]
	public MapState State { get; set; } = default!;

	protected string MapFile => State.Definition.Image.File;

	protected int MapWidth => State.Definition.Image.Width;

	protected int MapHeight => State.Definition.Image.Height;

	protected IEnumerable<RegionDefinition> RegionDefinitions => State.Definition.Regions;

	[JSInvokable]
	public async Task OnRegionSelectedHandler(
		string regionId
	) {
		await OnRegionSelected.InvokeAsync( regionId );
	}
}
