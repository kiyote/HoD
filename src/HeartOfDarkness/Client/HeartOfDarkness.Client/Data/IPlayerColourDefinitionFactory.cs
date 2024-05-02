namespace HeartOfDarkness.Client.Data;

public interface IPlayerColourDefinitionFactory {

	Task<IList<PlayerColourDefinition>> CreateAsync( CancellationToken cancellationToken );

}
