namespace HeartOfDarkness.Client.Model;

public record RegionDefinition(
	string Id,
	string Name,
	string Shape,
	string TokenXY,
	IList<string> AdjacentRegionIds
) {
}
