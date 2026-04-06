namespace HeartOfDarkness.Client.Pages.Components.PlayerColour;

public class PlayerColourComponentBase: ComponentBase {

	[Parameter]
	public PlayerColourDefinition Definition { get; init; } = PlayerColourDefinition.None;

	[Parameter]
	public required EventCallback<string> OnPlayerColourSelected { get; init; }

	protected async Task OnClickHandler(
		string patronId
	) {
		await OnPlayerColourSelected.InvokeAsync( patronId );
	}

}
