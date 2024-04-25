namespace HeartOfDarkness.Client.Store.App;

[FeatureState]
public record AppState(
	string Page,
	MapState Map
) {
	public static readonly AppState None = new AppState();

	public AppState() :
		this( "", MapState.None ) {
	}
}
