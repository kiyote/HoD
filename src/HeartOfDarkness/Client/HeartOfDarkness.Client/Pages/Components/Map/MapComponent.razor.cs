using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages;

public class MapComponentBase : ComponentBase {

	[Parameter]
	public required EventCallback<string> OnRegionSelected { get; init; }

	[Parameter, EditorRequired]
	public required MapDefinition MapDefinition { get; init; }

	[Parameter, EditorRequired]
	public required MapState MapState { get; init; }

	[Parameter]
	public RenderFragment ChildContent { get; set; } = default!;

	protected string MapFile => MapDefinition.Image.File;

	protected int MapWidth => MapDefinition.Image.Width;

	protected int MapHeight => MapDefinition.Image.Height;

	protected IEnumerable<RegionDefinition> RegionDefinitions => MapDefinition.Regions;

	[JSInvokable]
	public async Task OnRegionSelectedHandler(
		string regionId
	) {
		await OnRegionSelected.InvokeAsync( regionId );
	}
}
