namespace HeartOfDarkness.Client.Model;

public record Player(
	string PortOfEntry,
	int DramaPoints
) {
	public static readonly Player None = new Player( "", 0 );
}
