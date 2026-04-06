namespace HeartOfDarkness.Client.Pages;

public class MapRegionComponentBase: ComponentBase {

	[Parameter, EditorRequired]
	public RegionStyle RegionStyle { get; set; } = RegionStyle.Hidden;

	[Parameter, EditorRequired]
	public required string Id { get; init; }

	[Parameter, EditorRequired]
	public required string Shape { get; set; }

	[Parameter]
	public required EventCallback<string> OnRegionSelected { get; init; }

	protected string FinalClass  {
		get {
			return RegionStyle switch {
				RegionStyle.Hidden => "hidden",
				RegionStyle.Clickable => "selectable",
				RegionStyle.Highlighted => "highlighted",
				_ => throw new InvalidOperationException(),
			};
		}
	}

	protected async Task OnClickHandler(
		string regionId
	) {
		await OnRegionSelected.InvokeAsync( regionId );
	}
}
