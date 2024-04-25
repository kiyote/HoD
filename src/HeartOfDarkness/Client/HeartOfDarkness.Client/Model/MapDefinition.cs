namespace HeartOfDarkness.Client.Model;

public record MapDefinition(
	MapImageDefinition Image,
	IReadOnlyList<string> PortsOfEntry,
	IReadOnlyList<RegionDefinition> Regions
) {
	public static readonly MapDefinition None = new MapDefinition( MapImageDefinition.None, [], [] );
}
