
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticPatronDefinitionFactory : IPatronDefinitionFactory {
	Task<IList<PatronDefinition>> IPatronDefinitionFactory.CreateAsync(
		CancellationToken cancellationToken
	) {
		IList<PatronDefinition> result = [
			new PatronDefinition(
				new PatronImageDefinition(
					"img/HOD-interest_0.png",
					56,
					56
				),
				"Exploring",
				"Royal Geographic Society"
			),
			new PatronDefinition(
				new PatronImageDefinition(
					"img/HOD-interest_1.png",
					56,
					56
				),
				"Science",
				"University"
			),
			new PatronDefinition(
				new PatronImageDefinition(
					"img/HOD-interest_2.png",
					56,
					56
				),
				"Finance",
				"The City"
			),
			new PatronDefinition(
				new PatronImageDefinition(
					"img/HOD-interest_4.png",
					56,
					56
				),
				"Politician",
				"Westminster"
			),
			new PatronDefinition(
				new PatronImageDefinition(
					"img/HOD-interest_2.png",
					56,
					56
				),
				"The News",
				"Fleet Street"
			)
		];

		return Task.FromResult( result );
	}
}
