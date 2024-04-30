namespace HeartOfDarkness.Client.Model;

public record ResourceDefinition(
	ResourceImageDefinition Image,
	string Id
) {
	public static readonly ResourceDefinition None = new ResourceDefinition( ResourceImageDefinition.None, "" );
}
