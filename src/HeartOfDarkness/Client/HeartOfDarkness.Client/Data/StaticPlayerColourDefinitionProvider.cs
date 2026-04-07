
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticPlayerColourDefinitionProvider : IPlayerColourDefinitionProvider {

	private readonly IReadOnlyList<PlayerColourDefinition> _players =
		[
			new PlayerColourDefinition(
				"Blue",
				new ImageDefinition(
					"img/blue-explorer.png",
					56,
					56
				),
				new ImageDefinition(
					"img/blue-askari.png",
					56,
					56
				)
			),
			new PlayerColourDefinition(
				"Brown",
				new ImageDefinition(
					"img/brown-explorer.png",
					56,
					56
				),
				new ImageDefinition(
					"img/brown-askari.png",
					56,
					56
				)
			),
			new PlayerColourDefinition(
				"Green",
				new ImageDefinition(
					"img/green-explorer.png",
					56,
					56
				),
				new ImageDefinition(
					"img/green-askari.png",
					56,
					56
				)
			),
			new PlayerColourDefinition(
				"Grey",
				new ImageDefinition(
					"img/grey-explorer.png",
					56,
					56
				),
				new ImageDefinition(
					"img/grey-askari.png",
					56,
					56
				)
			),
			new PlayerColourDefinition(
				"Yellow",
				new ImageDefinition(
					"img/yellow-explorer.png",
					56,
					56
				),
				new ImageDefinition(
					"img/yellow-askari.png",
					56,
					56
				)
			),
		];

	Task<IReadOnlyList<PlayerColourDefinition>> IPlayerColourDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _players );
	}
}
