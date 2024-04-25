namespace HeartOfDarkness.Client.Store.Map;

[FeatureState]
public record MapState(
	Dictionary<string, RegionState> RegionState
) {
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
