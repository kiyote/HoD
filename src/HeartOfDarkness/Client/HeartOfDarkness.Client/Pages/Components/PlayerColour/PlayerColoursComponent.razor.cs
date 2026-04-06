namespace HeartOfDarkness.Client.Pages.Components.PlayerColour; 
public class PlayerColoursComponentBase: ComponentBase {

	[Parameter]
	public required IEnumerable<PlayerColourDefinition> Definitions { get; init; }

	[Parameter]
	public required EventCallback<string> OnPlayerColourSelected { get; init; }
}
