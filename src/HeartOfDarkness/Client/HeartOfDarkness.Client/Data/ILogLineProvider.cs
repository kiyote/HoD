namespace HeartOfDarkness.Client.Data;

public interface ILogLineProvider {

	Task<string> StartExpeditionAsync(
		string startingRegionId,
		CancellationToken cancellationToken
	);
}
