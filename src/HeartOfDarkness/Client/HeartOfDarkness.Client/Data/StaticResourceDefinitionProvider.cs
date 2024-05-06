
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticResourceDefinitionProvider : IResourceDefinitionProvider {

	private readonly IList<ResourceDefinition> _definitions =
		[
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/altimeter.png",
					73,
					73
				),
				"Altimeter",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/ammo.png",
					73,
					73
				),
				"Ammo",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/bible.png",
					73,
					73
				),
				"Bible",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/books.png",
					73,
					73
				),
				"Books",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/canoes.png",
					73,
					73
				),
				"Canoe",
				1,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/Cannibis.png",
					73,
					73
				),
				"Cannabis",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/cantine.png",
					73,
					73
				),
				"Canteen",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/diary.png",
					73,
					73
				),
				"Diary",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/fishing.png",
					73,
					73
				),
				"Fishing",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/guide.png",
					73,
					73
				),
				"Guide",
				1,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/machete.png",
					73,
					73
				),
				"Machete",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/painting.png",
					73,
					73
				),
				"Painting",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/pickax.png",
					73,
					73
				),
				"Pickaxe",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/quinine.png",
					73,
					73
				),
				"Quinine",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/revolver.png",
					73,
					73
				),
				"Revolver",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/rifle.png",
					73,
					73
				),
				"Rifle",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/surveyor.png",
					73,
					73
				),
				"Surveying",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ResourceImageDefinition(
					"img/telescope.png",
					73,
					73
				),
				"Telescope",
				int.MaxValue,
				false
			),
		];

	Task<IList<ResourceDefinition>> IResourceDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _definitions );
	}
}
