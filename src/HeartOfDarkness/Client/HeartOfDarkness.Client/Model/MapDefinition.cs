namespace HeartOfDarkness.Client.Model;

public record MapDefinition(
	ImageDefinition Image,
	IReadOnlyList<string> PortsOfEntry,
	IReadOnlyList<RegionDefinition> Regions
) {
	public static readonly MapDefinition None = new MapDefinition( ImageDefinition.None, [], [] );
}
