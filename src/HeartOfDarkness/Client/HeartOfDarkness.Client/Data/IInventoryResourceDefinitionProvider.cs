namespace HeartOfDarkness.Client.Data;

public interface IInventoryResourceDefinitionProvider {

	Task<IList<InventoryResourceDefinition>> GetAsync(
		CancellationToken cancellationToken
	);

}
