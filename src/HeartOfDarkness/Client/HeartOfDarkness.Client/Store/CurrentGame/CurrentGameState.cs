namespace HeartOfDarkness.Client.Store.CurrentGame;

[FeatureState]
public record CurrentGameState(
	bool IsLoading,
	Game Game,
	GameDefinition GameDefinition
) {
	public CurrentGameState()
		:this( false, Game.None, GameDefinition.None ) {
	}

	public static readonly CurrentGameState None = new CurrentGameState( false, Game.None, GameDefinition.None );
}
