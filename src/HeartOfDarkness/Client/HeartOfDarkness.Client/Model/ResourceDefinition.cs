namespace HeartOfDarkness.Client.Model;

public record ResourceDefinition(
	ImageDefinition Image,
	string Id,
	string Name,
	int Limit,
	bool Abundant
) {
	public static readonly ResourceDefinition None = new ResourceDefinition( ImageDefinition.None, "", "", 0, false );
}
