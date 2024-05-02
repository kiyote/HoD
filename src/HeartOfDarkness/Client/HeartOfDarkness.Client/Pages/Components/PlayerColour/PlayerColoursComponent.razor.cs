namespace HeartOfDarkness.Client.Pages.Components.PlayerColour; 
public class PlayerColoursComponentBase: ComponentBase {

	[Parameter]
	public IEnumerable<PlayerColourDefinition> Definitions { get; set; } = [];

	[Parameter]
	public EventCallback<string> OnPlayerColourSelected { get; set; }
}
