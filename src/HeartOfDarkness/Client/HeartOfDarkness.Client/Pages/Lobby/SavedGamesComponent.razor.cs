using Fluxor.Blazor.Web.Components;
using HeartOfDarkness.Client.Store.SavedGames;
using HeartOfDarkness.Client.Store.CurrentGame;
using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages.Lobby;

public class SavedGamesComponentBase: FluxorComponent {

	[Inject]
	protected IState<SavedGamesState> SavedGamesState { get; set; } = default!;

	[Inject]
	protected IDispatcher Dispatcher { get; set; } = default!;

	[Inject]
	protected NavigationManager Navigation { get; set; } = default!;

	protected override void OnInitialized() {
		base.OnInitialized();
		Dispatcher.Dispatch( new EnumerateSavedGamesAction() );
	}

	protected Task OnPlayGameClicked(
		Game game
	) {
		Dispatcher.Dispatch( new LoadSavedGameAction( game.Id ) );
		Navigation.NavigateTo( "/map" );
		return Task.CompletedTask;
	}

	protected Task OnDeleteGameClicked(
		Game game
	) {
		Dispatcher.Dispatch( new DeleteSavedGameAction( game.Id ) );
		return Task.CompletedTask;
	}
}
