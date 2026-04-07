
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticMatrixDefinitionProvider : IMatrixDefinitionProvider {

	private readonly MatrixDefinition _matrixDefinition = new MatrixDefinition(
		new ImageDefinition(
			"img/matrix.png",
			791,
			1021
		),
		[ // Askari
			new Position(124, 70),  // 1
			new Position(124, 146), // 2
			new Position(124, 220), // 3
			new Position(124, 294), // 4
			new Position(124, 370), // 5
			new Position(124, 444), // 6
			new Position(124, 519), // 7
			new Position(124, 594), // 8
			new Position(124, 674), // 9
			new Position(124, 744), // 10
		],
		[ // Sanity & Health
			new Position(687, 896), // 0
			new Position(617, 896), // 1
			new Position(544, 896), // 2
			new Position(472, 896), // 3
			new Position(400, 896), // 4
			new Position(327, 896), // 5
		],
		[ // Porters
			new Position(232, 72),
			new Position(232, 146),
			new Position(232, 220),
			new Position(232, 294),
			new Position(232, 370),
			new Position(232, 444),
			new Position(232, 519),
			new Position(232, 594),
			new Position(232, 670),
			new Position(232, 744),
		],
		[ // Gifts
			new Position(655, 145), // 0
			new Position(583, 145), // 1
			new Position(511, 145), // 2
			new Position(439, 145), // 3
			new Position(367, 145), // 4
			new Position(655, 73),  // 5
			new Position(583, 73),  // 6
			new Position(511, 73),  // 7
			new Position(439, 73),  // 8
			new Position(367, 73),  // 9
		],
		[ // Food
			new Position(655, 538), // 0
			new Position(583, 538), // 1
			new Position(511, 538), // 2
			new Position(439, 538), // 3
			new Position(367, 538), // 4
			new Position(655, 466), // 5
			new Position(583, 466), // 6
			new Position(511, 466), // 7
			new Position(439, 466), // 8
			new Position(367, 466), // 9
		]
	);

	Task<MatrixDefinition> IMatrixDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _matrixDefinition );
	}
}
