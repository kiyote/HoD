namespace HeartOfDarkness.Client.Pages;

public class PatronComponentBase: ComponentBase {

	[Parameter, EditorRequired]
	public string Image { get; set; } = "";

	[Parameter]
	public int Width { get; set; }

	[Parameter]
	public int Height { get; set; }

	[Parameter, EditorRequired]
	public string Id { get; set; } = "";

	[Parameter]
	public EventCallback<string> OnPatronSelected { get; set; }

	protected async Task OnClickHandler(
		string patronId
	) {
		await OnPatronSelected.InvokeAsync( patronId );
	}
}
