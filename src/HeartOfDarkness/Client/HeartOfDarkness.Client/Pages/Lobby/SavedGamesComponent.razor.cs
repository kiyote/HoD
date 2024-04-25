using Fluxor.Blazor.Web.Components;
using HeartOfDarkness.Client.Store;
using HeartOfDarkness.Client.Store.SavedGames;

namespace HeartOfDarkness.Client.Pages.Lobby;

public class SavedGamesComponentBase: FluxorComponent {

	[Inject]
	protected IState<SavedGamesState> SavedGamesState { get; set; } = default!;

	[Inject]
	protected IDispatcher Dispatcher { get; set; } = default!;

	protected IEnumerable<SavedGame> SavedGames => SavedGamesState.Value.Games;

	protected override void OnAfterRender(
		bool firstRender
	) {
		if (firstRender) {
			Dispatcher.Dispatch( new EnumerateSavedGamesAction() );
		}
		base.OnAfterRender( firstRender );
	}

	protected void OnPlayGameClicked(
		SavedGame game
	) {
		Dispatcher.Dispatch( new LoadSavedGameAction( game.Id ) );
	}

	protected void OnDeleteGameClicked(
		SavedGame game
	) {
		Dispatcher.Dispatch( new DeleteSavedGameAction( game.Id ) );
	}
}
