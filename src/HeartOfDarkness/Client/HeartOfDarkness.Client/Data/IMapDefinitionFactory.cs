namespace HeartOfDarkness.Client.Data;

public interface IMapDefinitionFactory {

	Task<MapDefinition> CreateAsync( CancellationToken cancellationToken );

}
