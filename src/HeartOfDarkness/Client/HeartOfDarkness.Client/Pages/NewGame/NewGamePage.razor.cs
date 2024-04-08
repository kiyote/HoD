using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages.NewGame;

public class NewGamePageBase : ComponentBase {

	[Inject]
	protected IGameFactory GameFactory { get; set; } = default!;

	[Inject]
	protected GameState State { get; set; } = default!;

	protected IEnumerable<Game> Games => State.Games;

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if (firstRender) {
			await State.LoadAsync().ConfigureAwait( false );
			StateHasChanged();
		}
	}

	public async Task OnDeleteGameClicked(
		Game game
	) {
		State.DeleteGame( game );
		await State.SaveAsync().ConfigureAwait( false );
	}

	protected async Task OnCreateGameClicked() {
		Game game = GameFactory.Create();
		State.AddGame( game );
		await State.SaveAsync().ConfigureAwait( false );
	}
}
