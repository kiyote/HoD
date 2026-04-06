namespace HeartOfDarkness.Client.Pages.Components.Map;

public class MapTokenComponentBase : ComponentBase {

	private string[] _coords = ["0", "0"];

	[Parameter, EditorRequired]
	public required RegionDefinition Definition { get; init; }

	[Parameter]
	public required ImageDefinition Image { get; init; }

	protected override void OnAfterRender(
		bool firstRender
	) {
		if( firstRender ) {
			_coords = Definition.Token.Split( ',' );
			if (_coords.Length != 2) {
				throw new InvalidOperationException( $"Token definition does not contain valid coordinates: `{Definition.Token}`" );
			}
			StateHasChanged();
		}
	}

	public string X => _coords[0];

	public string Y => _coords[1];
}
