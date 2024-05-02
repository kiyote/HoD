
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticResourceDefinitionFactory : IResourceDefinitionFactory {
	Task<IList<ResourceDefinition>> IResourceDefinitionFactory.CreateAsync(
		CancellationToken cancellationToken
	) {
		IList<ResourceDefinition> result = [
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/altimeter.png",
					73,
					73
				),
				"Altimeter",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/ammo.png",
					73,
					73
				),
				"Ammo",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/bible.png",
					73,
					73
				),
				"Bible",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/books.png",
					73,
					73
				),
				"Books",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/canoes.png",
					73,
					73
				),
				"Canoes",
				1
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/Cannibis.png",
					73,
					73
				),
				"Cannabis",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/cantine.png",
					73,
					73
				),
				"Canteen",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/diary.png",
					73,
					73
				),
				"Diary",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/fishing.png",
					73,
					73
				),
				"Fishing Gear",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/guide.png",
					73,
					73
				),
				"Guide",
				1
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/machete.png",
					73,
					73
				),
				"Machete",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/painting.png",
					73,
					73
				),
				"Painting Supplies",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/pickax.png",
					73,
					73
				),
				"Pickaxe",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/quinine.png",
					73,
					73
				),
				"Quinine",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/revolver.png",
					73,
					73
				),
				"Revolver",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/rifle.png",
					73,
					73
				),
				"Rifle",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/surveyor.png",
					73,
					73
				),
				"Survey Equipment",
				int.MaxValue
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/telescope.png",
					73,
					73
				),
				"Telescope",
				int.MaxValue
			),
		];

		return Task.FromResult( result );
	}
}
