
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticPatronDefinitionProvider : IPatronDefinitionProvider {

	private readonly IList<PatronDefinition> _patrons =
		[
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_0.png",
					56,
					56
				),
				"Exploring",
				"Royal Geographic Society"
			),
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_1.png",
					56,
					56
				),
				"Science",
				"University"
			),
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_2.png",
					56,
					56
				),
				"Finance",
				"The City"
			),
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_4.png",
					56,
					56
				),
				"Politician",
				"Westminster"
			),
			new PatronDefinition(
				new ImageDefinition(
					"img/HOD-interest_2.png",
					56,
					56
				),
				"The News",
				"Fleet Street"
			)
		];

	Task<IList<PatronDefinition>> IPatronDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _patrons );
	}
}
