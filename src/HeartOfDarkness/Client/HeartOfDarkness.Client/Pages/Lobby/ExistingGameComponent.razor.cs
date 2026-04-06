namespace HeartOfDarkness.Client.Pages.Lobby;

public class ExistingGameComponentBase : ComponentBase {

	[Parameter]
	public required Game Game { get; init; }
}

