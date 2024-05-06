namespace HeartOfDarkness.Client.Data;

public interface IPlayerColourDefinitionProvider {

	Task<IList<PlayerColourDefinition>> GetAsync(
		CancellationToken cancellationToken
	);

}
