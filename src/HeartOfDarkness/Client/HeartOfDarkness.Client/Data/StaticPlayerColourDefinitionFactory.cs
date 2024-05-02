
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticPlayerColourDefinitionFactory : IPlayerColourDefinitionFactory {
	Task<IList<PlayerColourDefinition>> IPlayerColourDefinitionFactory.CreateAsync(
		CancellationToken cancellationToken
	) {
		IList<PlayerColourDefinition> result = [
			new PlayerColourDefinition(
				new PlayerColourImageDefinition(
					"img/blue-explorer.png",
					56,
					56
				),
				"Blue"
			),
			new PlayerColourDefinition(
				new PlayerColourImageDefinition(
					"img/brown-explorer.png",
					56,
					56
				),
				"Brown"
			),
			new PlayerColourDefinition(
				new PlayerColourImageDefinition(
					"img/green-explorer.png",
					56,
					56
				),
				"Green"
			),
			new PlayerColourDefinition(
				new PlayerColourImageDefinition(
					"img/grey-explorer.png",
					56,
					56
				),
				"Grey"
			),
			new PlayerColourDefinition(
				new PlayerColourImageDefinition(
					"img/yellow-explorer.png",
					56,
					56
				),
				"Yellow"
			),
		];

		return Task.FromResult( result );
	}
}
