using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Pages.Components.Inventory; 

public class InventoryComponentBase: ComponentBase {

	[Parameter]
	public required PlayerInventory Inventory { get; init; }

	[Parameter]
	public PlayerColourDefinition ColourDefinition { get; set; } = PlayerColourDefinition.None;

	[Inject]
	public required IInventoryResourceDefinitionProvider InventoryResourceDefinitionProvider { get; init; }

	[Inject]
	public required IResourceDefinitionProvider ResourceDefinitionProvider { get; init; }

	protected IReadOnlyList<InventoryResourceDefinition> InventoryResourceDefinitions { get; set; } = [];

	protected IReadOnlyList<ResourceDefinition> ResourceDefinitions { get; set; } = [];

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if (firstRender) {
			InventoryResourceDefinitions = await InventoryResourceDefinitionProvider.GetAsync( CancellationToken.None );
			ResourceDefinitions = await ResourceDefinitionProvider.GetAsync( CancellationToken.None );
			StateHasChanged(); // Must be called or inventory will not display due to being []
		}
	}

	protected string GetImageFile( InventoryResourceDefinition definition ) {
		return definition.Image.File.Replace( "{colour}", ColourDefinition.Id.ToLowerInvariant(), StringComparison.InvariantCulture );
	}
}
