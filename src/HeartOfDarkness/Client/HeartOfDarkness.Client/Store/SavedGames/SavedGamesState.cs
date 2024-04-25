namespace HeartOfDarkness.Client.Store.SavedGames;

[FeatureState]
public record SavedGamesState(
	bool IsLoading,
	IEnumerable<SavedGame> Games
) {

	public SavedGamesState() : this(
		true,
		[]
	) {
	}
}
