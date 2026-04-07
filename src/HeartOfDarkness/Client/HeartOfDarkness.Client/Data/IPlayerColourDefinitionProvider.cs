namespace HeartOfDarkness.Client.Data;

public interface IPlayerColourDefinitionProvider {

	Task<IReadOnlyList<PlayerColourDefinition>> GetAsync(
		CancellationToken cancellationToken
	);

}
