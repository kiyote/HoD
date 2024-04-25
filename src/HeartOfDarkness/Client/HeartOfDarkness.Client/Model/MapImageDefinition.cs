namespace HeartOfDarkness.Client.Model;

public record MapImageDefinition(
	string File,
	int Width,
	int Height
) {
	public static readonly MapImageDefinition None = new MapImageDefinition( "", 0, 0 );
}
