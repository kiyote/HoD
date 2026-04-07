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
	public required IMapStateFactory MapStateFactory { get; init; }

	[Inject]
	public required IGameDefinitionFactory GameDefinitionFactory { get; init; }

	[Inject]
	public required IDispatcher Dispatcher { get; init; }

	protected GameDefinition GameDefinition { get; set; } = GameDefinition.None;

	protected MapState MapState { get; set; } = MapState.None;

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
			GameDefinition = await GameDefinitionFactory.CreateAsync();
			MapState = await MapStateFactory.CreateAsync( GameDefinition.MapDefinition );
			foreach( ResourceDefinition definition in GameDefinition.ResourceDefinitions ) {
				NewGame.Inventory[definition.Id] = 0;
			}
			foreach( InventoryResourceDefinition definition in GameDefinition.InventoryResourceDefinitions ) {
				NewGame.Inventory[definition.Id] = definition.Start;
			}
			StateHasChanged();
		}
	}

	protected void RegionSelectedHandler(
		string regionId
	) {
		DisplayState = DisplayState.CreateGame;
		NewGame.PortOfEntry = regionId;
	}

	protected void PlayerColourSelectedHandler(
		string playerColourId
	) {
		DisplayState = DisplayState.CreateGame;
		NewGame.Colour = playerColourId;
		PlayerColourDefinition = GameDefinition.PlayerColourDefinitions.First( d => d.Id == playerColourId );

		_ = ResourcesButtonAttributes?.Remove( "disabled" );
	}

	protected void PatronSelectedHandler(
		string patronId
	) {
		DisplayState = DisplayState.CreateGame;
		NewGame.Patron = patronId;
	}

	protected void DoSelectPortOfEntry() {
		foreach( string regionId in GameDefinition.MapDefinition.PortsOfEntry ) {
			MapState[regionId] = MapState[regionId] with { Style = Model.RegionStyle.Highlighted };
		}
		DisplayState = DisplayState.SelectPortOfEntry;
	}

	protected void DoSelectPlayerColour() {
		DisplayState = DisplayState.SelectPlayerColour;
	}

	protected void DoSelectPatron() {
		DisplayState = DisplayState.SelectPatron;
	}

	protected void DoSelectResources() {
		DisplayState = DisplayState.SelectResources;
	}

	protected void OnCreateGameClicked() {
		Dispatcher.Dispatch( new CreateNewGameAction( GameDefinition, NewGame ) );
	}

	protected void OnCancelClicked() {
		DisplayState = DisplayState.CreateGame;
	}
}
