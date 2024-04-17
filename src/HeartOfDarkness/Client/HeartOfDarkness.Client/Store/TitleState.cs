namespace HeartOfDarkness.Client.Store;

[FeatureState]
public record TitleState(
	string Title
) {

	public TitleState():this("") {
	}
}
