using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages.CreateGame;

public class PatronsComponentBase: ComponentBase {

	[Parameter]
	public EventCallback<string> OnPatronSelected { get; set; }

	[Parameter, EditorRequired]
	public IEnumerable<PatronDefinition> PatronDefinitions { get; set; } = [];

	[JSInvokable]
	public async Task OnPatronSelectedHandler(
		string patronId
	) {
		await OnPatronSelected.InvokeAsync( patronId );
	}
}
