namespace HeartOfDarkness.Client.Model;

public record PlayerColourDefinition(
	string Id,
	ImageDefinition ExplorerToken,
	ImageDefinition AskariToken
) {
	public static readonly PlayerColourDefinition None = new PlayerColourDefinition(
		"",
		ImageDefinition.None,
		ImageDefinition.None
	);
}
