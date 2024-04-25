namespace HeartOfDarkness.Client.Store.CurrentGame;

[FeatureState]
public record CurrentGameState(
	bool IsLoading,
	Game Game
) {
	public CurrentGameState()
		:this( false, Game.None ) {
	}
}
