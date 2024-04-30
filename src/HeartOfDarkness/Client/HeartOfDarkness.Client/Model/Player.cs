namespace HeartOfDarkness.Client.Model;

public record Player(
	string PortOfEntry,
	int DramaPoints,
	PlayerInventory Inventory
) {
	public static readonly Player None = new Player( "", 0, PlayerInventory.None );
}
