namespace HeartOfDarkness.Client.Data;

public interface IResourceDefinitionFactory {

	Task<IList<ResourceDefinition>> CreateAsync( CancellationToken cancellationToken );

}
