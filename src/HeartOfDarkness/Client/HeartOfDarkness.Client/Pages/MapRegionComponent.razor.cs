namespace HeartOfDarkness.Client.Pages;

public class MapRegionComponentBase: ComponentBase {

	[Parameter, EditorRequired]
	public RegionStyle RegionStyle { get; set; } = RegionStyle.Hidden;

	[Parameter, EditorRequired]
	public string Id { get; set; } = "";

	[Parameter, EditorRequired]
	public string Shape { get; set; } = "";

	[Parameter]
	public EventCallback<string> OnRegionSelected { get; set; }

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
