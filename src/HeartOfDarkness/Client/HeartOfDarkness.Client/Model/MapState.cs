namespace HeartOfDarkness.Client.Model;

public sealed record MapState(
	Dictionary<string, RegionState> Regions
) {

	public static readonly MapState None = new MapState();

	public MapState()
		:this([]) {
	}

	public RegionState this[string regionId] {
		get {
			return Regions[regionId];
		}
		set {
			Regions[regionId] = value;
		}
	}
}

public record RegionState(
	string RegionId,
	RegionStyle Style,
	ImageDefinition? Token
) {
}

public enum RegionStyle {
	Hidden,
	Clickable,
	Highlighted
}
