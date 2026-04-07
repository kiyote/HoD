namespace HeartOfDarkness.Client.Pages.Components.Matrix;

public class MatrixComponentBase : ComponentBase {

	[Parameter, EditorRequired]
	public required MatrixDefinition MatrixDefinition { get; init; }

	[Parameter, EditorRequired]
	public required Game Game { get; init; }

	[Parameter, EditorRequired]
	public required PlayerColourDefinition PlayerColourDefinition { get; init; }

	protected Position AskariPosition { get; set; } = Position.None;

	protected ImageDefinition AskariToken { get; set; } = ImageDefinition.None;

	protected string MatrixFile => MatrixDefinition.Image.File;

	protected int MatrixWidth => MatrixDefinition.Image.Width;

	protected int MatrixHeight => MatrixDefinition.Image.Height;

	protected override void OnAfterRender(
		bool firstRender
	) {
		if (firstRender) {
			AskariToken = PlayerColourDefinition.AskariToken;
			AskariPosition = MatrixDefinition.AskariTrack[ Game.Player.Inventory[InventoryResourceDefinition.AskariId] ];
			StateHasChanged();
		}
		base.OnAfterRender( firstRender );
	}

}
