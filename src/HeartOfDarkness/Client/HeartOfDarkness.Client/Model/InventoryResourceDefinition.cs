namespace HeartOfDarkness.Client.Model; 
public record InventoryResourceDefinition(
	ImageDefinition Image,
	string Id,
	string Name,
	int Minimum,
	int Maximum,
	int Increment,
	int Start
) {
	public static readonly InventoryResourceDefinition None = new InventoryResourceDefinition( ImageDefinition.None, "", "", 0, 0, 0, 0 );

	public const string AmmoId = "inventory_ammo";
	public const string AskariId = "inventory_askari";
	public const string FoodId = "inventory_food";
	public const string GiftsId = "inventory_gifts";
	public const string PorterId = "inventory_porter";
}
