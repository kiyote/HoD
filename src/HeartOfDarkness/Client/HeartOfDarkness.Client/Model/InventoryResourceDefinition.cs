namespace HeartOfDarkness.Client.Model; 
public record InventoryResourceDefinition(
	InventoryResourceImageDefinition Image,
	string Id,
	string Name,
	int Minimum,
	int Maximum,
	int Increment
) {
	public static readonly InventoryResourceDefinition None = new InventoryResourceDefinition( InventoryResourceImageDefinition.None, "", "", 0, 0, 0 );
}
