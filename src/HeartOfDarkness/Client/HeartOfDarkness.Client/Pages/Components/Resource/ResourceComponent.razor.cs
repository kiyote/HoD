using System.Reflection.Metadata;

namespace HeartOfDarkness.Client.Pages.Components.Resource;

public class ResourceComponentBase : ComponentBase {

	[Parameter, EditorRequired]
	public required ResourceDefinition Definition { get; init; }

	[Parameter]
	public required int Count { get; init; }

	[Parameter]
	public required int Limit { get; init; }

	[Parameter]
	public required EventCallback<(string, int)> OnResourceSelected { get; init; }

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
