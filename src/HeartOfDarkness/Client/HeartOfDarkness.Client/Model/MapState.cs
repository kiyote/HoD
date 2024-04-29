namespace HeartOfDarkness.Client.Model;

public sealed record MapState {

	private readonly Dictionary<string, RegionState> _regions;

	public MapState(
		MapDefinition definition
	) {
		Definition = definition;
		_regions = [];
		foreach( RegionDefinition region in definition.Regions ) {
			_regions[region.Id] = new RegionState( region.Id, RegionStyle.Hidden );
		}
	}

	public MapDefinition Definition { get; }

	public RegionState this[string regionId] {
		get {
			return _regions[regionId];
		}
		set {
			_regions[regionId] = value;
		}
	}
}

public record RegionState(
	string RegionId,
	RegionStyle Style
) {
}

public enum RegionStyle {
	Hidden,
	Clickable,
	Highlighted
}
