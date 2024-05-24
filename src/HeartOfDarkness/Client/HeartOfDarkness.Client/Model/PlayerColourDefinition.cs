namespace HeartOfDarkness.Client.Model;

public record PlayerColourDefinition(
	ImageDefinition Explorer,
	ImageDefinition Askari,
	string Id
) {
	public static readonly PlayerColourDefinition None = new PlayerColourDefinition(
		ImageDefinition.None,
		ImageDefinition.None,
		"" );
}
