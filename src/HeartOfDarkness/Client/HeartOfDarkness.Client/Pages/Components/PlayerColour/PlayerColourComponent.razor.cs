namespace HeartOfDarkness.Client.Pages.Components.PlayerColour;

public class PlayerColourComponentBase: ComponentBase {

	[Parameter]
	public PlayerColourDefinition Definition { get; set; } = PlayerColourDefinition.None;

	[Parameter]
	public EventCallback<string> OnPlayerColourSelected { get; set; }

	protected async Task OnClickHandler(
		string patronId
	) {
		await OnPlayerColourSelected.InvokeAsync( patronId );
	}

}
