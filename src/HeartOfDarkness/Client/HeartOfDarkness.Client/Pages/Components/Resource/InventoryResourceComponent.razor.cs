namespace HeartOfDarkness.Client.Pages.Components.Resource;
public class InventoryResourceComponentBase : ComponentBase {

	[Parameter]
	public InventoryResourceDefinition Definition { get; set; } = default!;

	[Parameter]
	public PlayerColourDefinition ColourDefinition { get; set; } = PlayerColourDefinition.None;

	[Parameter]
	public int Count { get; set; }

	[Parameter]
	public int Limit { get; set; }

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
