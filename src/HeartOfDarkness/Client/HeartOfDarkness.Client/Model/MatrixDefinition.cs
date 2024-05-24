namespace HeartOfDarkness.Client.Model;

public record MatrixDefinition(
	ImageDefinition Image,
	IList<Position> AskariTrack
) {
	public static readonly MatrixDefinition None = new MatrixDefinition( ImageDefinition.None, [] );
}
