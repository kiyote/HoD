namespace HeartOfDarkness.Client.Pages.Components.Map;

public class TurnTrackComponentBase: ComponentBase {

	[Parameter, EditorRequired]
	public required Game GameState { get; init; }

	[Parameter, EditorRequired]
	public required GameDefinition GameDefinition { get; init; }

	protected ImageDefinition DiseaseToken => GameDefinition.MapDefinition.DiseaseToken;

	protected ImageDefinition HorrorToken => GameDefinition.MapDefinition.HorrorToken;

	protected Position DiseasePosition { get; set; } = Position.None;

	protected Position HorrorPosition { get; set; } = Position.None;

	protected override void OnAfterRender(
		bool firstRender
	) {
		if( firstRender ) {
			DiseasePosition = GameDefinition.MapDefinition.TurnTrack[GameState.Disease];
			HorrorPosition = GameDefinition.MapDefinition.TurnTrack[GameState.Horror];
			StateHasChanged();
		}
		base.OnAfterRender( firstRender );
	}
}
