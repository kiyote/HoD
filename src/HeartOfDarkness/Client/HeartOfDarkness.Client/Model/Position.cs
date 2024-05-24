namespace HeartOfDarkness.Client.Model;

public record Position(int X, int Y) {
	public static readonly Position None = new Position( int.MinValue, int.MinValue );
}
