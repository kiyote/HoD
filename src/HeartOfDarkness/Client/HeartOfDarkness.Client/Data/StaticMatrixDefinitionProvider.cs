
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticMatrixDefinitionProvider : IMatrixDefinitionProvider {

	private readonly MatrixDefinition _matrixDefinition = new MatrixDefinition(
		new ImageDefinition(
			"img/matrix.png",
			791,
			1021
		),
		[
			new Position(124, 70),
			new Position(124, 146),
			new Position(124, 220),
			new Position(124, 294),
			new Position(124, 370),
			new Position(124, 444),
			new Position(124, 594)
		]
	);

	Task<MatrixDefinition> IMatrixDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult(_matrixDefinition);
	}
}
