namespace HeartOfDarkness.Client.Model;

public record RegionDefinition(
	string Id,
	string Shape,
	string Token,
	IList<string> AdjacentRegionIds
) {
}
