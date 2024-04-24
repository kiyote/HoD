namespace HeartOfDarkness.Components;

public class Regions {

	private readonly Dictionary<string, Region> _regions;

	public Regions() {
		_regions = new Dictionary<string, Region>() {
			{ RegionId.Angola, new Region( RegionId.Angola ) }
		};
	}

	public Region this[string id] {
		get {
			return _regions[id];
		}
	}
}
