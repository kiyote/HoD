namespace HeartOfDarkness.Client.Data;

internal sealed class PorterCapacityProvider : IPorterCapacityProvider {
	int IPorterCapacityProvider.GetAvailable(
		PlayerInventory inventory
	) {
		int porters = inventory[InventoryResourceDefinition.PorterId];
		int availablePorters = porters - 2;
		int food = inventory[InventoryResourceDefinition.FoodId];
		int gifts = inventory[InventoryResourceDefinition.GiftsId];
		int foodWeight = food - ( food % 10 );
		int giftsWeight = gifts - ( gifts % 10 );

		return ( availablePorters * 10 ) - ( foodWeight + giftsWeight );
	}

	int IPorterCapacityProvider.GetMaximum(
		PlayerInventory inventory
	) {
		int porters = inventory[InventoryResourceDefinition.PorterId];
		int availablePorters = porters - 2;
		return availablePorters * 10;
	}
}
