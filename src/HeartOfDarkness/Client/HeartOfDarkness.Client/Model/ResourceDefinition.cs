namespace HeartOfDarkness.Client.Model;

public record ResourceDefinition(
	ResourceImageDefinition Image,
	string Id,
	int Limit,
	bool Abundant
) {
	public static readonly ResourceDefinition None = new ResourceDefinition( ResourceImageDefinition.None, "", 0, false );
}
