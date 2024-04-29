using HeartOfDarkness.Client.Data;
using HeartOfDarkness.Client.Store.App;
using HeartOfDarkness.Client.Store.CurrentGame;

namespace HeartOfDarkness.Client.Pages.CreateGame;

public class CreateGamePageBase : ComponentBase {

	[Inject]
	protected IMapStateFactory MapStateFactory { get; set; } = default!;

	[Inject]
	protected IMapDefinitionFactory MapDefinitionFactory { get; set; } = default!;

	protected Model.MapState MapState { get; set; } = default!;

	protected bool SelectPortOfEntry { get; set; }

	protected NewGame NewGame { get; set; } = default!;

	protected override void OnInitialized() {
		NewGame = new NewGame();
		base.OnInitialized();
	}

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if( firstRender ) {
			MapDefinition mapDefinition = await MapDefinitionFactory.CreateAsync( CancellationToken.None );
			MapState = await MapStateFactory.CreateAsync( mapDefinition, CancellationToken.None );
		}
	}

	protected Task RegionSelectedHandler(
		string regionId
	) {
		SelectPortOfEntry = false;
		NewGame.PortOfEntry = regionId;
		return Task.CompletedTask;
	}

	protected Task DoSelectPortOfEntry() {
		foreach( string regionId in MapState.Definition.PortsOfEntry ) {
			MapState[regionId] = MapState[regionId] with { Style = Model.RegionStyle.Highlighted };
		}
		SelectPortOfEntry = true;
		StateHasChanged();
		return Task.CompletedTask;
	}

	protected static Task OnCreateGameClicked() {
		return Task.CompletedTask;
	}

	protected Task OnCancelClicked() {
		SelectPortOfEntry = false;
		return Task.CompletedTask;
	}
}
