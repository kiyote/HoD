namespace HeartOfDarkness.Client.Model;

public record ImageDefinition(
	string File,
	int Width,
	int Height
) {
	public static readonly ImageDefinition None = new ImageDefinition( "", 0, 0 );
}
