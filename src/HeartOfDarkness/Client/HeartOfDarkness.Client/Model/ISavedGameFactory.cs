namespace HeartOfDarkness.Client.Model;

public interface ISavedGameFactory {

	SavedGame CreateFromGame(
		Game game
	);

}
