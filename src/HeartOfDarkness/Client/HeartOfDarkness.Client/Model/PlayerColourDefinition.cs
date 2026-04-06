namespace HeartOfDarkness.Client.Model;

public record PlayerColourDefinition(
	string Id,
	ImageDefinition Explorer,
	ImageDefinition Askari
) {
	public static readonly PlayerColourDefinition None = new PlayerColourDefinition(
		"",
		ImageDefinition.None,
		ImageDefinition.None
	);
}
