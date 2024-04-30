namespace HeartOfDarkness.Client.Model;

public record ResourceImageDefinition(
	string File,
	int Width,
	int Height
) {
	public static readonly ResourceImageDefinition None = new ResourceImageDefinition( "", 0, 0 );
}
