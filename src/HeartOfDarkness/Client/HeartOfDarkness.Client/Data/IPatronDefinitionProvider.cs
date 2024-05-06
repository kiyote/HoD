namespace HeartOfDarkness.Client.Data;

public interface IPatronDefinitionProvider {

	Task<IList<PatronDefinition>> GetAsync(
		CancellationToken cancellationToken
	);

}
