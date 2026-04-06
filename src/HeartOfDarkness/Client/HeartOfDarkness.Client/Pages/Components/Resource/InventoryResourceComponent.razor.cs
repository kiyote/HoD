namespace HeartOfDarkness.Client.Pages.Components.Resource;
public class InventoryResourceComponentBase : ComponentBase {

	[Parameter]
	public required InventoryResourceDefinition Definition { get; init; }

	[Parameter]
	public PlayerColourDefinition ColourDefinition { get; init; } = PlayerColourDefinition.None;

	[Parameter]
	public required int Count { get; init; }

	[Parameter]
	public required int Limit { get; init; }

	public string ImageFile {
		get {
			return Definition.Image.File.Replace( "{colour}", ColourDefinition.Id.ToLowerInvariant(), StringComparison.InvariantCulture );
		}
	}

	[Parameter]
	public EventCallback<(string, int)> OnResourceSelected { get; set; }

	protected async Task OnClickHandler(
		string resourceId
	) {
		await OnResourceSelected.InvokeAsync( (resourceId, +1) );
	}

	protected async Task OnSubtractHandler(
		string resourceId
	) {
		await OnResourceSelected.InvokeAsync( (resourceId, -1) );
	}
}
