namespace HeartOfDarkness.Client.Store.App;

public record RegionState(
	string RegionId,
	RegionStyle Style
) {
	public string FinalClass {
		get {
			return Style switch {
				RegionStyle.Hidden => "hidden",
				RegionStyle.Clickable => "selectable",
				RegionStyle.Highlighted => "highlighted",
				_ => throw new InvalidOperationException(),
			};
		}
	}
}
