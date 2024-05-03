
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticInventoryResourceDefinitionFactory : IInventoryResourceDefinitionFactory {
	Task<IList<InventoryResourceDefinition>> IInventoryResourceDefinitionFactory.CreateAsync(
		CancellationToken cancellationToken
	) {
		IList<InventoryResourceDefinition> result = [
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-ammo.png",
					56,
					56
				),
				"inventory_ammo",
				"Ammo",
				0,
				8,
				1
			),
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-askari.png",
					56,
					56
				),
				"inventory_askari",
				"Askari",
				0,
				8,
				1
			),
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-food.png",
					56,
					56
				),
				"inventory_food",
				"Food",
				20,
				int.MaxValue,
				10
			),
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-gifts.png",
					56,
					56
				),
				"inventory_gifts",
				"Gifts",
				10,
				int.MaxValue,
				5
			),
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-porter.png",
					56,
					56
				),
				"inventory_porter",
				"Porter",
				0,
				10,
				1
			),
		];

		return Task.FromResult( result );
	}
}
