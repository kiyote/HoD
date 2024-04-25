using HeartOfDarkness.Client.Store.CurrentGame;
using HeartOfDarkness.Client.Store.Map;
using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages;

public partial class MapComponent : ComponentBase {

	public enum Style {
		Hidden,
		Selectable,
		Highlighted
	}

	[Inject]
	protected IJSRuntime JS { get; set; } = default!;

	[Inject]
	protected IState<CurrentGameState> GameState { get; set; } = default!;

	[Inject]
	protected IState<MapState> MapState { get; set; } = default!;

	[Inject]
	protected HttpClient Http { get; set; } = default!;

	[Parameter]
	public EventCallback<string> OnRegionSelected { get; set; }

	protected string MapFile => GameState.Value.Game.MapDefinition.Image.File;

	protected int MapWidth => GameState.Value.Game.MapDefinition.Image.Width;

	protected int MapHeight => GameState.Value.Game.MapDefinition.Image.Height;

	protected IEnumerable<RegionDefinition> RegionDefinitions => GameState.Value.Game.MapDefinition.Regions;


	[JSInvokable]
	public async Task OnRegionSelectedHandler(
		string regionId
	) {
		await OnRegionSelected.InvokeAsync( regionId );
	}
}
