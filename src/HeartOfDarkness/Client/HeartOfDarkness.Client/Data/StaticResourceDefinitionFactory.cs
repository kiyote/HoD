
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
				"Altimeter"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/ammo.png",
					73,
					73
				),
				"Ammo"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/bible.png",
					73,
					73
				),
				"Bible"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/books.png",
					73,
					73
				),
				"Books"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/canoes.png",
					73,
					73
				),
				"Canoes"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/Cannibis.png",
					73,
					73
				),
				"Cannabis"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/cantine.png",
					73,
					73
				),
				"Canteen"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/diary.png",
					73,
					73
				),
				"Diary"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/fishing.png",
					73,
					73
				),
				"Fishing Gear"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/guide.png",
					73,
					73
				),
				"Guide"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/machete.png",
					73,
					73
				),
				"Machete"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/painting.png",
					73,
					73
				),
				"Painting Supplies"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/pickax.png",
					73,
					73
				),
				"Pickaxe"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/quinine.png",
					73,
					73
				),
				"Quinine"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/revolver.png",
					73,
					73
				),
				"Revolver"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/rifle.png",
					73,
					73
				),
				"Rifle"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/surveyor.png",
					73,
					73
				),
				"Survey Equipment"
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/telescope.png",
					73,
					73
				),
				"Telescope"
			),
		];

		return Task.FromResult( result );
	}
}
