namespace HeartOfDarkness.Client.Data;

internal sealed class ResourceLimitProvider : IResourceLimitProvider {

	int IResourceLimitProvider.GetMaximum(
		IEnumerable<InventoryResourceDefinition> resources,
		string resourceId
	) {
		InventoryResourceDefinition definition = resources.First( r => r.Id == resourceId );
		return definition.Maximum;
	}

	int IResourceLimitProvider.GetMaximum(
		IEnumerable<ResourceDefinition> resources,
		int playerCount,
		string resourceId
	) {
		ResourceDefinition definition = resources.First( r => r.Id == resourceId );
		int limit = playerCount;
		if( definition.Abundant ) {
			limit *= 2;
		}
		return limit;
	}
}
