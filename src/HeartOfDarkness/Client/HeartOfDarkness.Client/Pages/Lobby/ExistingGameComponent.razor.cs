namespace HeartOfDarkness.Client.Pages.Lobby;

public class ExistingGameComponentBase : ComponentBase {

	[Parameter]
	public Game Game { get; set; } = default!;
}

