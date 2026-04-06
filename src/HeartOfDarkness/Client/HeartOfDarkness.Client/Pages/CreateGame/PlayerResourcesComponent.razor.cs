using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Pages.CreateGame;

public class PlayerResourcesComponentBase : ComponentBase {

	[Parameter]
	public PlayerColourDefinition PlayerColourDefinition { get; set; } = PlayerColourDefinition.None;

	[Parameter]
	public required IEnumerable<InventoryResourceDefinition> InventoryResourceDefinitions { get; init; }

	[Parameter]
	public required IEnumerable<ResourceDefinition> ResourceDefinitions { get; init; }

	[Parameter]
	public required EventCallback<ResourceDefinition> OnResourceSelected { get; init; }

	[Parameter]
	public required PlayerInventory Inventory { get; init; }

	[Inject]
	public required IPorterCapacityProvider PorterCapacity { get; init; }

	[Inject]
	public required IResourceLimitProvider ResourceLimitProvider { get; init; }

	protected int CreditsRemaining { get; set; } = 20;

	protected int TotalCredits { get; set; } = 20;


	protected Task InventoryResourceSelectedHandler(
		(string inventoryResourceId, int direction) args
	) {
		if( CreditsRemaining > 0 || args.direction < 0 ) {
			if( args.inventoryResourceId == InventoryResourceDefinition.FoodId
				|| args.inventoryResourceId == InventoryResourceDefinition.GiftsId
			) {
				if( args.direction > 0
					&& PorterCapacity.GetAvailable( Inventory ) == 0
				) {
					return Task.CompletedTask;
				}
			}
			InventoryResourceDefinition definition = InventoryResourceDefinitions.First( d => d.Id == args.inventoryResourceId );
			if( TryAddResource( args.inventoryResourceId, definition.Start, definition.Maximum, ( definition.Increment * args.direction ) ) ) {
				CreditsRemaining -= ( 1 * args.direction );
			}
		}
		return Task.CompletedTask;
	}

	protected Task ResourceSelectedHandler(
		(string resourceId, int direction) args
	) {
		if( CreditsRemaining > 0 || args.direction < 0 ) {
			int limit = ResourceLimitProvider.GetMaximum( ResourceDefinitions, 1, args.resourceId );
			if( TryAddResource( args.resourceId, 0, limit, args.direction ) ) {
				CreditsRemaining -= ( 1 * args.direction );
			}
		}
		return Task.CompletedTask;
	}

	private bool TryAddResource(
		string resourceId,
		int minimum,
		int maximum,
		int increment
	) {
		Inventory[resourceId] += increment;
		if( Inventory[resourceId] > maximum ) {
			Inventory[resourceId] = maximum;
			return false;
		} else if( Inventory[resourceId] < minimum ) {
			Inventory[resourceId] = minimum;
			return false;
		}
		return true;
	}
}
