namespace HeartOfDarkness.Client.Pages.Lobby;

public class ExistingGameComponentBase : ComponentBase {

	[Parameter]
	public SavedGame Game { get; set; } = default!;
}

