
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticResourceDefinitionProvider : IResourceDefinitionProvider {

	private readonly IList<ResourceDefinition> _definitions =
		[
			new ResourceDefinition(
				new ImageDefinition(
					"img/altimeter.png",
					73,
					73
				),
				"altimeter",
				"Altimeter",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/ammo.png",
					73,
					73
				),
				"ammo",
				"Ammo",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/bible.png",
					73,
					73
				),
				"bible",
				"Bible",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/books.png",
					73,
					73
				),
				"books",
				"Books",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/canoes.png",
					73,
					73
				),
				"canoe",
				"Canoe",
				1,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/Cannibis.png",
					73,
					73
				),
				"cannabis",
				"Cannabis",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/cantine.png",
					73,
					73
				),
				"canteen",
				"Canteen",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/diary.png",
					73,
					73
				),
				"diary",
				"Diary",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/fishing.png",
					73,
					73
				),
				"fishing",
				"Fishing",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/guide.png",
					73,
					73
				),
				"guide",
				"Guide",
				1,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/machete.png",
					73,
					73
				),
				"machete",
				"Machete",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/painting.png",
					73,
					73
				),
				"painting",
				"Painting",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/pickax.png",
					73,
					73
				),
				"pickaxe",
				"Pickaxe",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/quinine.png",
					73,
					73
				),
				"quinine",
				"Quinine",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/revolver.png",
					73,
					73
				),
				"revolver",
				"Revolver",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/rifle.png",
					73,
					73
				),
				"rifle",
				"Rifle",
				int.MaxValue,
				true
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/surveyor.png",
					73,
					73
				),
				"surveying",
				"Surveying",
				int.MaxValue,
				false
			),
			new ResourceDefinition(
				new ImageDefinition(
					"img/telescope.png",
					73,
					73
				),
				"telescope",
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
