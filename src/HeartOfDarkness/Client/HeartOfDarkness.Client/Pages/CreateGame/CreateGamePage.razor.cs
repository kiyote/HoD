using HeartOfDarkness.Client.Data;
using HeartOfDarkness.Client.Store.App;

namespace HeartOfDarkness.Client.Pages.CreateGame;

public enum DisplayState {
	CreateGame,
	SelectPortOfEntry,
	SelectPatron,
	SelectResources
}

public class CreateGamePageBase : ComponentBase {



	[Inject]
	protected IMapStateFactory MapStateFactory { get; set; } = default!;

	[Inject]
	protected IMapDefinitionFactory MapDefinitionFactory { get; set; } = default!;

	[Inject]
	protected IPatronDefinitionFactory PatronDefinitionFactory { get; set; } = default!;

	[Inject]
	protected IResourceDefinitionFactory ResourceDefinitionFactory { get; set; } = default!;

	protected IList<PatronDefinition> PatronDefinitions { get; set; } = [];

	protected IList<ResourceDefinition> ResourceDefinitions { get; set; } = [];

	protected Model.MapState MapState { get; set; } = default!;

	protected DisplayState DisplayState { get; set; }

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
			PatronDefinitions = await PatronDefinitionFactory.CreateAsync( CancellationToken.None );
			ResourceDefinitions = await ResourceDefinitionFactory.CreateAsync( CancellationToken.None );
		}
	}

	protected Task RegionSelectedHandler(
		string regionId
	) {
		DisplayState = DisplayState.CreateGame;
		NewGame.PortOfEntry = regionId;
		return Task.CompletedTask;
	}

	protected Task PatronSelectedHandler(
		string patronId
	) {
		DisplayState = DisplayState.CreateGame;
		NewGame.Patron = patronId;
		return Task.CompletedTask;
	}

	protected Task DoSelectPortOfEntry() {
		foreach( string regionId in MapState.Definition.PortsOfEntry ) {
			MapState[regionId] = MapState[regionId] with { Style = Model.RegionStyle.Highlighted };
		}
		DisplayState = DisplayState.SelectPortOfEntry;
		return Task.CompletedTask;
	}

	protected Task DoSelectPatron() {
		DisplayState = DisplayState.SelectPatron;
		return Task.CompletedTask;
	}

	protected Task DoSelectResources() {
		DisplayState = DisplayState.SelectResources;
		return Task.CompletedTask;
	}

	protected static Task OnCreateGameClicked() {
		return Task.CompletedTask;
	}

	protected Task OnCancelClicked() {
		DisplayState = DisplayState.CreateGame;
		return Task.CompletedTask;
	}
}
