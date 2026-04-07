namespace HeartOfDarkness.Client.Model;

public record MapDefinition(
	ImageDefinition Image,
	ImageDefinition DiseaseToken,
	ImageDefinition HorrorToken,
	IReadOnlyList<string> PortsOfEntry,
	IReadOnlyList<RegionDefinition> Regions,
	IReadOnlyList<Position> TurnTrack
) {
	public static readonly MapDefinition None = new MapDefinition( ImageDefinition.None, ImageDefinition.None, ImageDefinition.None, [], [], [] );

	public RegionDefinition this[string regionId] {
		get {
			return Regions.First( r => r.Id == regionId );
		}
	}
}
