using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages.NewGame;

public class ExistingGameComponentBase : ComponentBase {

	[Parameter]
	public Game Game { get; set; } = default!;

	[Inject]
	protected GameState State { get; set; } = default!;

	public async Task OnDeleteGameClicked() {
		State.DeleteGame( Game );
		await State.SaveAsync().ConfigureAwait( false );
	}
}

