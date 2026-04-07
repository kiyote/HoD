namespace HeartOfDarkness.Client.Data;

public interface IInventoryResourceDefinitionProvider {

	Task<IReadOnlyList<InventoryResourceDefinition>> GetAsync(
		CancellationToken cancellationToken
	);

}
