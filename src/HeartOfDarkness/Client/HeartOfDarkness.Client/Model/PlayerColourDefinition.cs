namespace HeartOfDarkness.Client.Model;

public record PlayerColourDefinition(
	PlayerColourImageDefinition Image,
	string Id
) {
	public static readonly PlayerColourDefinition None = new PlayerColourDefinition( PlayerColourImageDefinition.None, "" );
}
