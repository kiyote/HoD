using System.Runtime.CompilerServices;
using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Pages.CreateGame;

public class PlayerResourcesComponentBase : ComponentBase {

	[Parameter]
	public PlayerColourDefinition PlayerColourDefinition { get; set; } = PlayerColourDefinition.None;

	[Parameter]
	public IEnumerable<InventoryResourceDefinition> InventoryResourceDefinitions { get; set; } = default!;

	[Parameter]
	public IEnumerable<ResourceDefinition> ResourceDefinitions { get; set; } = default!;

	[Parameter]
	public EventCallback<ResourceDefinition> OnResourceSelected { get; set; }

	[Parameter]
	public PlayerInventory Inventory { get; set; } = default!;

	[Inject]
	protected IPorterCapacityProvider PorterCapacity { get; set; } = default!;


	[Inject]
	protected IResourceLimitProvider ResourceLimitProvider { get; set; } = default!;


	protected Task InventoryResourceSelectedHandler(
		(string inventoryResourceId, int direction) args
	) {
		InventoryResourceDefinition definition = InventoryResourceDefinitions.First( d => d.Id == args.inventoryResourceId );
		_ = TryAddResource( args.inventoryResourceId, definition.Minimum, definition.Maximum, ( definition.Increment * args.direction ) );
		StateHasChanged();
		return Task.CompletedTask;
	}

	protected Task ResourceSelectedHandler(
		(string resourceId, int direction) args
	) {
		int limit = ResourceLimitProvider.GetMaximum( ResourceDefinitions, 1, args.resourceId );
		_ = TryAddResource( args.resourceId, 0, limit, args.direction );
		StateHasChanged();
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
