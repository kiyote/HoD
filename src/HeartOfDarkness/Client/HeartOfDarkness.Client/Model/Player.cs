namespace HeartOfDarkness.Client.Model;

public record Player(
	string ColourId,
	string RegionId,
	int DramaPoints,
	PlayerInventory Inventory
) {
	public static readonly Player None = new Player( "", "", 0, PlayerInventory.None );
}
