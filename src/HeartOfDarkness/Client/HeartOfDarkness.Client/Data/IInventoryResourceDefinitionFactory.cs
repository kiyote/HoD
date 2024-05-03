namespace HeartOfDarkness.Client.Data;

public interface IInventoryResourceDefinitionFactory {

	Task<IList<InventoryResourceDefinition>> CreateAsync( CancellationToken cancellationToken );

}
