using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages;

public class LobbyBase: ComponentBase {

	[Inject]
	protected NavigationManager Navigation { get; set; } = default!;

	protected void OnNewGameClicked() {
		Navigation.NavigateTo( "NewGame" );
	}
}
