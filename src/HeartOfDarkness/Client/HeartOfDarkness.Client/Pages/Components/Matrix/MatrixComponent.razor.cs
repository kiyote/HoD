using HeartOfDarkness.Client.Store.CurrentGame;

namespace HeartOfDarkness.Client.Pages.Components.Matrix;

public class MatrixComponentBase : ComponentBase {

	[Parameter, EditorRequired]
	public CurrentGameState GameState { get; set; } = default!;

	protected Position AskariPosition { get; set; } = Position.None;

	protected ImageDefinition AskariToken { get; set; } = ImageDefinition.None;

	protected string MatrixFile => GameState.Game.MatrixDefinition.Image.File;

	protected int MatrixWidth => GameState.Game.MatrixDefinition.Image.Width;

	protected int MatrixHeight => GameState.Game.MatrixDefinition.Image.Height;

	protected override void OnAfterRender(
		bool firstRender
	) {
		if (firstRender) {
			AskariToken = GameState.Game.PlayerColourDefinition.Askari;
			AskariPosition = GameState.Game.MatrixDefinition.AskariTrack[ GameState.Game.Player.Inventory[InventoryResourceDefinition.AskariId] ];
			StateHasChanged();
		}
		base.OnAfterRender( firstRender );
	}

}
