namespace HeartOfDarkness.Client.Model;

public record Player(
	string ColourId,
	string RegionId,
	int DramaPoints,
	int Sanity,
	int Health,
	PlayerInventory Inventory
) {
	public static readonly Player None = new Player( "", "", 0, 0, 0, PlayerInventory.None );
}
