using HeartOfDarkness.Client.Data;
using HeartOfDarkness.Client.Store;

namespace HeartOfDarkness.Client.Pages.CreateGame;

public enum DisplayState {
	CreateGame,
	SelectPortOfEntry,
	SelectPatron,
	SelectResources,
	SelectPlayerColour
}

public class CreateGamePageBase : ComponentBase {

	[Inject]
	protected IMapStateFactory MapStateFactory { get; set; } = default!;

	[Inject]
	protected IMapDefinitionProvider MapDefinitionProvider { get; set; } = default!;

	[Inject]
	protected IPatronDefinitionProvider PatronDefinitionProvider { get; set; } = default!;

	[Inject]
	protected IResourceDefinitionProvider ResourceDefinitionProvider { get; set; } = default!;

	[Inject]
	protected IPlayerColourDefinitionProvider PlayerColourDefinitionProvider { get; set; } = default!;

	[Inject]
	protected IInventoryResourceDefinitionProvider InventoryResourceDefinitionProvider { get; set; } = default!;

	[Inject]
	protected IDispatcher Dispatcher { get; set; } = default!;

	protected IList<PatronDefinition> PatronDefinitions { get; set; } = [];

	protected IList<ResourceDefinition> ResourceDefinitions { get; set; } = [];

	protected IList<PlayerColourDefinition> PlayerColourDefinitions { get; set; } = [];

	protected IList<InventoryResourceDefinition> InventoryResourceDefinitions { get; set; } = [];

	protected Model.MapState MapState { get; set; } = default!;

	protected DisplayState DisplayState { get; set; }

	protected NewGame NewGame { get; set; } = default!;

	protected PlayerColourDefinition PlayerColourDefinition { get; set; } = PlayerColourDefinition.None;

	[Parameter]
	public Dictionary<string, object?> ResourcesButtonAttributes { get; set; } =
		new Dictionary<string, object?>()
		{
			{ "disabled", "" }
		};

	protected override void OnInitialized() {
		NewGame = new NewGame();
		base.OnInitialized();
	}

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if( firstRender ) {
			MapDefinition mapDefinition = await MapDefinitionProvider.GetAsync( CancellationToken.None );
			MapState = await MapStateFactory.CreateAsync( mapDefinition, CancellationToken.None );
			PatronDefinitions = await PatronDefinitionProvider.GetAsync( CancellationToken.None );
			ResourceDefinitions = await ResourceDefinitionProvider.GetAsync( CancellationToken.None );
			PlayerColourDefinitions = await PlayerColourDefinitionProvider.GetAsync( CancellationToken.None );
			InventoryResourceDefinitions = await InventoryResourceDefinitionProvider.GetAsync( CancellationToken.None );
			foreach(ResourceDefinition definition in ResourceDefinitions) {
				NewGame.Inventory[definition.Id] = 0;
			}
			foreach( InventoryResourceDefinition definition in InventoryResourceDefinitions ) {
				NewGame.Inventory[definition.Id] = definition.Start;
			}
			StateHasChanged();
		}	
	}

	protected Task RegionSelectedHandler(
		string regionId
	) {
		DisplayState = DisplayState.CreateGame;
		NewGame.PortOfEntry = regionId;
		return Task.CompletedTask;
	}

	protected Task PlayerColourSelectedHandler(
		string playerColourId
	) {
		DisplayState = DisplayState.CreateGame;
		NewGame.Colour = playerColourId;
		PlayerColourDefinition = PlayerColourDefinitions.First( d => d.Id == playerColourId );
		
		_ = ResourcesButtonAttributes?.Remove( "disabled" );
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

	protected Task DoSelectPlayerColour() {
		DisplayState = DisplayState.SelectPlayerColour;
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

	protected Task OnCreateGameClicked() {
		Dispatcher.Dispatch( new CreateNewGameAction( NewGame ) );
		return Task.CompletedTask;
	}

	protected Task OnCancelClicked() {
		DisplayState = DisplayState.CreateGame;
		return Task.CompletedTask;
	}
}
