namespace HeartOfDarkness.Client.Model;

public record PlayerColourDefinition(
	ImageDefinition Image,
	string Id
) {
	public static readonly PlayerColourDefinition None = new PlayerColourDefinition( ImageDefinition.None, "" );
}
