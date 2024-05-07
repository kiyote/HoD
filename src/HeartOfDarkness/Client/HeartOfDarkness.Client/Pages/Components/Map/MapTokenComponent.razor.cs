namespace HeartOfDarkness.Client.Pages.Components.Map;

public class MapTokenComponentBase: ComponentBase {

	private string[] _coords = ["0", "0"];

	[Parameter, EditorRequired]
	public RegionDefinition Definition { get; set; } = default!;

	[Parameter]
	public ImageDefinition Image { get; set; } = ImageDefinition.None;

	protected override void OnAfterRender(
		bool firstRender
	) {
		if (firstRender) {
			_coords = Definition.Token.Split( ',' );
			StateHasChanged();
		}
	}

	public string X => _coords[0];

	public string Y => _coords[1];
}
