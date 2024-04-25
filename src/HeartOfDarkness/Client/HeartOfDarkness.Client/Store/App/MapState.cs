namespace HeartOfDarkness.Client.Store.App;

public record MapState(
	Dictionary<string, RegionState> RegionState
) {
	public static readonly MapState None = new MapState();

	public MapState()
	: this(
		  []
	) {
	}

	public RegionState this[string regionId] {
		get {
			return RegionState[regionId];
		}
		set {
			RegionState[regionId] = value;
		}
	}
}
