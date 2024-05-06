namespace HeartOfDarkness.Client.Data;

public interface IResourceLimitProvider {

	int GetMaximum(
		IEnumerable<InventoryResourceDefinition> resources,
		string resourceId
	);

	int GetMaximum(
		IEnumerable<ResourceDefinition> resources,
		int playerCount,
		string resourceId
	);

}
