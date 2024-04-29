namespace HeartOfDarkness.Client.Data;

public interface ISavedGameFactory {

	SavedGame CreateFromGame(
		Game game
	);

}
