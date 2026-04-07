namespace HeartOfDarkness.Client.Model;

public record MatrixDefinition(
	ImageDefinition Image,
	IList<Position> AskariTrack,
	IList<Position> SanityAndHealthTrack,
	IList<Position> PortersTrack,
	IList<Position> GiftsTrack,
	IList<Position> FoodTrack
) {
	public static readonly MatrixDefinition None = new MatrixDefinition( ImageDefinition.None, [], [], [], [], [] );
}
