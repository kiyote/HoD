using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages.NewGame;

public class NewGamePageBase : ComponentBase {

	[Inject]
	protected IGameFactory GameFactory { get; set; } = default!;

	[Inject]
	protected GameState GameState { get; set; } = default!;

	protected IEnumerable<Game> Games => GameState.Games;

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if( firstRender ) {
			await GameState.LoadAsync().ConfigureAwait( false );
			StateHasChanged();
		}
	}

	public async Task OnDeleteGameClicked(
		Game game
	) {
		GameState.DeleteGame( game );
		await GameState.SaveAsync().ConfigureAwait( false );
	}

	protected async Task OnCreateGameClicked() {
		Game game = GameFactory.Create();
		GameState.AddGame( game );
		await GameState.SaveAsync().ConfigureAwait( false );
	}
}
