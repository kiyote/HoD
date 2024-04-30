namespace HeartOfDarkness.Client.Data;

public interface IPatronDefinitionFactory {

	Task<IList<PatronDefinition>> CreateAsync( CancellationToken cancellationToken );

}
