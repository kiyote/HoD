namespace HeartOfDarkness.Client.Pages.Components.Patron;

public class PatronComponentBase : ComponentBase {

	[Parameter, EditorRequired]
	public required string Image { get; init; }

	[Parameter]
	public required int Width { get; init; }

	[Parameter]
	public required int Height { get; init; }

	[Parameter, EditorRequired]
	public required string Id { get; init; }

	[Parameter]
	public required EventCallback<string> OnPatronSelected { get; init; }

	protected async Task OnClickHandler(
		string patronId
	) {
		await OnPatronSelected.InvokeAsync( patronId );
	}
}
