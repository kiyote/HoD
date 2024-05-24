namespace HeartOfDarkness.Client.Data;

public interface IMatrixDefinitionProvider {

	Task<MatrixDefinition> GetAsync(
		CancellationToken cancellationToken
	);
}
