namespace HeartOfDarkness.Client.Data;

public interface IResourceDefinitionProvider {

	Task<IReadOnlyList<ResourceDefinition>> GetAsync(
		CancellationToken cancellationToken
	);

}
