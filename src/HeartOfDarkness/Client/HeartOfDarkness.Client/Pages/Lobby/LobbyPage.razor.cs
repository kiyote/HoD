using HeartOfDarkness.Client.Store.SavedGames;

namespace HeartOfDarkness.Client.Pages;

public class LobbyPageBase: ComponentBase {

	[Inject]
	protected IGameFactory GameFactory { get; set; } = default!;

	[Inject]
	public IDispatcher Dispatcher { get; set; } = default!;

	[Inject]
	public IState<SavedGamesState> SavedGamesState { get; set; } = default!;

	[Inject]
	public NavigationManager Navigation { get; set; } = default!;

	protected async Task OnCreateGameClicked() {
		Game game = await GameFactory.CreateAsync( CancellationToken.None );
		Dispatcher.Dispatch( new CreateNewGameAction( game ) );
		//Navigation.NavigateTo( "/portofentry" );
	}
}
