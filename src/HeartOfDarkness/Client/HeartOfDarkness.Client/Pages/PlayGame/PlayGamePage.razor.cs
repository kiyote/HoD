using HeartOfDarkness.Client.Data;
using HeartOfDarkness.Client.Store.CurrentGame;

namespace HeartOfDarkness.Client.Pages.PlayGame;

public class PlayGamePageBase: ComponentBase {

	protected enum DisplayState {
		Unknown,
		Map,
		Matrix
	}

	[Inject]
	protected IState<CurrentGameState> GameState { get; set; } = default!;

	[Inject]
	protected IPlayerColourDefinitionProvider PlayerColourDefinitionProvider { get; set; } = default!;

	protected DisplayState PageState { get; set; } = DisplayState.Map;

	protected IList<PlayerColourDefinition> PlayerColourDefinitions { get; set; } = [];

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if (firstRender) {
			PlayerColourDefinitions = await PlayerColourDefinitionProvider.GetAsync( CancellationToken.None );
			StateHasChanged();
		}
	}
}
