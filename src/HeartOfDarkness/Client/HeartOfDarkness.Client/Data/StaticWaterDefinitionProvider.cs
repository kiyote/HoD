namespace HeartOfDarkness.Client.Data {
	internal sealed class StaticWaterDefinitionProvider : IWaterDefinitionProvider {

		private readonly IList<WaterDefinition> _definitions = [
			new WaterDefinition(
				new ImageDefinition(
					"img/lake-source.png",
					56,
					56
				),
				"lake-source",
				"Lake source",
				2,
				2,
				true,
				true,
				"Exploring"
			),
			new WaterDefinition(
				new ImageDefinition(
					"img/lake-source2.png",
					56,
					56
				),
				"lake-source-largest",
				"Largest lake source",
				3,
				2,
				true,
				true,
				"Exploring"
			),
			new WaterDefinition(
				new ImageDefinition(
					"img/marsh-river.png",
					56,
					56
				),
				"marsh-river",
				"Marsh",
				2,
				2,
				false,
				true,
				"Exploring"
			),
			new WaterDefinition(
				new ImageDefinition(
					"img/marsh-source.png",
					56,
					56
				),
				"marsh-source",
				"Marsh river source",
				2,
				2,
				true,
				true,
				"Exploring"
			),
			new WaterDefinition(
				new ImageDefinition(
					"img/mountain-range.png",
					56,
					56
				),
				"mountain-source",
				"Mountain river source",
				2,
				2,
				true,
				false,
				"Exploring"
			),
			new WaterDefinition(
				new ImageDefinition(
					"img/waterfall.png",
					56,
					56
				),
				"waterfall",
				"Waterfall",
				2,
				2,
				false,
				false,
				"Exploring"
			),
			new WaterDefinition(
				new ImageDefinition(
					"img/source.png",
					56,
					56
				),
				"river-source",
				"River source",
				0,
				0,
				true,
				false,
				""
			),
			new WaterDefinition(
				new ImageDefinition(
					"img/river.png",
					56,
					56
				),
				"river",
				"River",
				0,
				0,
				false,
				false,
				""
			),
			new WaterDefinition(
				new ImageDefinition(
					"img/fork.png",
					56,
					56
				),
				"fork",
				"River fork",
				0,
				0,
				false,
				false,
				""
			)
		];

		Task<IList<WaterDefinition>> IWaterDefinitionProvider.GetAsync(
			CancellationToken cancellationToken
		) {
			return Task.FromResult( _definitions );
		}
	}
}
