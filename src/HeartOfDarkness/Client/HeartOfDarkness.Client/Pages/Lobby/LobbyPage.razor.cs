namespace HeartOfDarkness.Client.Pages;

public class LobbyPageBase : ComponentBase {

	[Inject]
	public required NavigationManager Navigation { get; init; }

	protected void OnCreateGameClicked() {
		Navigation.NavigateTo( "/create" );
	}
}
