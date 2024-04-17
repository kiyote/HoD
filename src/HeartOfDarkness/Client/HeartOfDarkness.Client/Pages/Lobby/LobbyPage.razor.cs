using Fluxor;
using HeartOfDarkness.Client.Store;
using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages;

public class LobbyPageBase: ComponentBase {

	[Inject]
	public NavigationManager Navigation { get; set; } = default!;

	[Inject]
	protected IGameFactory GameFactory { get; set; } = default!;

	[Inject]
	protected GameState GameState { get; set; } = default!;

	[Inject]
	public IDispatcher Dispatcher { get; set; } = default!;

	protected IEnumerable<Game> Games => GameState.Games;

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if( firstRender ) {
			await GameState.LoadAsync().ConfigureAwait( false );
			StateHasChanged();
		}
	}

	public async Task OnPlayGameClicked(
		Game game
	) {
		GameState.LoadGame( game );

		Dispatcher.Dispatch( new SetTitleAction( "Set Up" ) );

		await GameState.SaveAsync().ConfigureAwait( false );
		Navigation.NavigateTo( "/map" );
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
