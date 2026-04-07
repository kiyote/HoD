namespace HeartOfDarkness.Client.Pages.Components.Map;

public class MapRegionTokenComponentBase : ComponentBase {

	private string[] _coords = ["0", "0"];

	[Parameter, EditorRequired]
	public required RegionDefinition RegionDefinition { get; init; }

	[Parameter]
	public required ImageDefinition Image { get; init; }

	protected override void OnAfterRender(
		bool firstRender
	) {
		if( firstRender ) {
			_coords = RegionDefinition.TokenXY.ToXY();
			StateHasChanged();
		}
	}

	public string X => _coords[0];

	public string Y => _coords[1];
}
