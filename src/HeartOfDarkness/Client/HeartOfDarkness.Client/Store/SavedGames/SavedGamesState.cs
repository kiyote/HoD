namespace HeartOfDarkness.Client.Store.SavedGames;

[FeatureState]
public record SavedGamesState(
	bool IsLoading,
	IEnumerable<Game> Games
) {

	public SavedGamesState() : this(
		true,
		[]
	) {
	}
}
