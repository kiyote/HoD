
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticInventoryResourceDefinitionProvider : IInventoryResourceDefinitionProvider {

	private readonly IList<InventoryResourceDefinition> _definitions =
[
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-ammo.png",
					56,
					56
				),
				InventoryResourceDefinition.AmmoId,
				"Ammo",
				0,
				8,
				1,
				0
			),
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-askari.png",
					56,
					56
				),
				InventoryResourceDefinition.AskariId,
				"Askari",
				0,
				8,
				1,
				6
			),
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-food.png",
					56,
					56
				),
				InventoryResourceDefinition.FoodId,
				"Food",
				0,
				int.MaxValue,
				10,
				20
			),
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-gifts.png",
					56,
					56
				),
				InventoryResourceDefinition.GiftsId,
				"Gifts",
				0,
				int.MaxValue,
				5,
				10
			),
			new InventoryResourceDefinition(
				new InventoryResourceImageDefinition(
					"img/{colour}-porter.png",
					56,
					56
				),
				InventoryResourceDefinition.PorterId,
				"Porter",
				0,
				10,
				1,
				8
			),
		];


	Task<IList<InventoryResourceDefinition>> IInventoryResourceDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _definitions );
	}
}
