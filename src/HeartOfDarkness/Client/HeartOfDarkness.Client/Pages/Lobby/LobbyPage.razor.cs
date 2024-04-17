using HeartOfDarkness.Client.Store.SavedGames;
using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages;

public class LobbyPageBase: ComponentBase {

	[Inject]
	protected IGameFactory GameFactory { get; set; } = default!;

	[Inject]
	public IDispatcher Dispatcher { get; set; } = default!;

	[Inject]
	public IState<SavedGamesState> SavedGamesState { get; set; } = default!;

	protected Task OnCreateGameClicked() {
		Game game = GameFactory.Create();
		Dispatcher.Dispatch( new AddSavedGameAction( game ) );
		return Task.CompletedTask;
	}
}
