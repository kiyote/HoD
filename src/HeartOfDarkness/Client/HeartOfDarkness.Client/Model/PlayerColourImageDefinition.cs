namespace HeartOfDarkness.Client.Model;

public record PlayerColourImageDefinition(
	string File,
	int Width,
	int Height
) {
	public static readonly PlayerColourImageDefinition None = new PlayerColourImageDefinition( "", 0, 0 );
}
