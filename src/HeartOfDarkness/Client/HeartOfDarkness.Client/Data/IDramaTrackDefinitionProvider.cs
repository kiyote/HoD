namespace HeartOfDarkness.Client.Data;

public interface IDramaTrackDefinitionProvider {

	Task<DramaTrackDefinition> GetAsync( CancellationToken cancellationToken );

}
