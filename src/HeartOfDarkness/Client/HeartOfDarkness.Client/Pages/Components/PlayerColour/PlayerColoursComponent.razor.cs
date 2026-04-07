namespace HeartOfDarkness.Client.Pages.Components.PlayerColour; 
public class PlayerColoursComponentBase: ComponentBase {

	[Parameter, EditorRequired]
	public required IReadOnlyList<PlayerColourDefinition> Definitions { get; init; }

	[Parameter]
	public required EventCallback<string> OnPlayerColourSelected { get; init; }
}
