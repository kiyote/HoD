
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticPlayerColourDefinitionProvider : IPlayerColourDefinitionProvider {

	private readonly IList<PlayerColourDefinition> _players =
		[
			new PlayerColourDefinition(
				new ImageDefinition(
					"img/blue-explorer.png",
					56,
					56
				),
				"Blue"
			),
			new PlayerColourDefinition(
				new ImageDefinition(
					"img/brown-explorer.png",
					56,
					56
				),
				"Brown"
			),
			new PlayerColourDefinition(
				new ImageDefinition(
					"img/green-explorer.png",
					56,
					56
				),
				"Green"
			),
			new PlayerColourDefinition(
				new ImageDefinition(
					"img/grey-explorer.png",
					56,
					56
				),
				"Grey"
			),
			new PlayerColourDefinition(
				new ImageDefinition(
					"img/yellow-explorer.png",
					56,
					56
				),
				"Yellow"
			),
		];

	Task<IList<PlayerColourDefinition>> IPlayerColourDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _players );
	}
}
