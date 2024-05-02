namespace HeartOfDarkness.Client.Model;

public record ResourceDefinition(
	ResourceImageDefinition Image,
	string Id,
	int Limit
) {
	public static readonly ResourceDefinition None = new ResourceDefinition( ResourceImageDefinition.None, "", 0 );
}
