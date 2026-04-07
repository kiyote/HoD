namespace HeartOfDarkness.Client.Data;

public interface ILogLineProvider {

	Task<string> StartExpeditionAsync(
		MapDefinition mapDefinition,
		string startingRegionId,
		CancellationToken cancellationToken
	);
}
