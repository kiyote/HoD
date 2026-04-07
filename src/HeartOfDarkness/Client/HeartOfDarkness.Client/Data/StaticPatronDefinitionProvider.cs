
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticPatronDefinitionProvider : IPatronDefinitionProvider {

	private readonly IReadOnlyList<PatronDefinition> _patrons =
		[
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_0.png",
					56,
					56
				),
				"Exploring",
				"Royal Geographic Society",
				"If you place any Water Source, Water Feature, Scenery, Mountain, Lake or Lost City markers gain an addtional 3DP."
			),
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_1.png",
					56,
					56
				),
				"Science",
				"University",
				"If you place any Culture or Flora markers, gain an additional 3DP."
			),
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_2.png",
					56,
					56
				),
				"Finance",
				"The City",
				"If you place any Mineral markers, gain an additional 3DP."
			),
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_4.png",
					56,
					56
				),
				"Politician",
				"Westminster",
				"If you deal with a Kingdom or Warrior Nation, gain an additional 3DP."
			),
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_2.png",
					56,
					56
				),
				"The News",
				"Fleet Street",
				"If you draw a Special Discovery marker, gain an additional 3DP."
			)
		];

	Task<IReadOnlyList<PatronDefinition>> IPatronDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _patrons );
	}
}
