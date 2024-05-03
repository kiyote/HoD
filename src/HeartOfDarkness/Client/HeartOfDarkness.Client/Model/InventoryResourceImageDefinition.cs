namespace HeartOfDarkness.Client.Model;

public record InventoryResourceImageDefinition(
	string File,
	int Width,
	int Height
) {
	public static readonly InventoryResourceImageDefinition None = new InventoryResourceImageDefinition( "", 0, 0 );
}

