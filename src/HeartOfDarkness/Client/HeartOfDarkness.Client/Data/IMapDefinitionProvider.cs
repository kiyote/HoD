namespace HeartOfDarkness.Client.Data;

public interface IMapDefinitionProvider {

	Task<MapDefinition> GetAsync(
		CancellationToken cancellationToken
	);

}
