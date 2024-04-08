using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages.NewGame;

public class ExistingGameComponentBase : ComponentBase {

	[Parameter]
	public Game Game { get; set; } = default!;
}

