namespace HeartOfDarkness.Client.Data;

public interface IResourceDefinitionProvider {

	Task<IList<ResourceDefinition>> GetAsync(
		CancellationToken cancellationToken
	);

}
