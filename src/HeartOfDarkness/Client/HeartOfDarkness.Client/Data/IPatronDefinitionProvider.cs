namespace HeartOfDarkness.Client.Data;

public interface IPatronDefinitionProvider {

	Task<IReadOnlyList<PatronDefinition>> GetAsync(
		CancellationToken cancellationToken
	);

}
