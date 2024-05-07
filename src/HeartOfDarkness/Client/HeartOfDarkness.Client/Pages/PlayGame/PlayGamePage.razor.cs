using HeartOfDarkness.Client.Store.CurrentGame;

namespace HeartOfDarkness.Client.Pages.PlayGame;

public class PlayGamePageBase: ComponentBase {

	protected enum DisplayState {
		Unknown,
		Map,
		Matrix
	}

	[Inject]
	public IState<CurrentGameState> GameState { get; set; } = default!;

	protected DisplayState PageState { get; set; } = DisplayState.Map;

}
