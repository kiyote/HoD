namespace HeartOfDarkness.Client.Pages;

public class LobbyPageBase : ComponentBase {

	[Inject]
	protected NavigationManager Navigation { get; set; } = default!;

	protected void OnCreateGameClicked() {
		Navigation.NavigateTo( "/create" );
	}
}
