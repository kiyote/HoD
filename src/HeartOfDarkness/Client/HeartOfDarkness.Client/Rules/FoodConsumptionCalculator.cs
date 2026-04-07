namespace HeartOfDarkness.Client.Rules;

internal sealed class FoodConsumptionCalculator : IFoodConsumptionCalculator {
	int IFoodConsumptionCalculator.ConsumedFood(
		Game game,
		GameDefinition gameDefinition
	) {
		int askari = game.Player.Inventory.Resources[InventoryResourceDefinition.AskariId];
		int porters = game.Player.Inventory.Resources[InventoryResourceDefinition.PorterId];

		return askari + porters;
	}
}
