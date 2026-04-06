using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages.CreateGame;

public class PatronsComponentBase: ComponentBase {

	[Parameter]
	public required EventCallback<string> OnPatronSelected { get; init; }

	[Parameter, EditorRequired]
	public required IEnumerable<PatronDefinition> PatronDefinitions { get; init; }

	[JSInvokable]
	public async Task OnPatronSelectedHandler(
		string patronId
	) {
		await OnPatronSelected.InvokeAsync( patronId );
	}
}
