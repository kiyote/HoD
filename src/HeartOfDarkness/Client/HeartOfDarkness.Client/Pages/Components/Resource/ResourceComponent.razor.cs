namespace HeartOfDarkness.Client.Pages.Components.Resource;

public class ResourceComponentBase: ComponentBase {

	[Parameter, EditorRequired]
	public ResourceDefinition Definition { get; set; } = default!;

	[Parameter]
	public int Count { get; set; }

	[Parameter]
	public EventCallback<string> OnResourceSelected { get; set; }

	protected async Task OnClickHandler(
		string resourceId
	) {
		await OnResourceSelected.InvokeAsync( resourceId );
	}
}
