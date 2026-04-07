namespace HeartOfDarkness.Client.Data;

public interface IGameDefinitionFactory {

	Task<GameDefinition> CreateAsync(
		CancellationToken cancellationToken = default
	);
}
