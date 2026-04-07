namespace HeartOfDarkness.Client.Data;

public interface IGameFactory {

	Task<Game> CreateNewAsync(
		NewGame newGame,
		GameDefinition gameDefinition,
		CancellationToken cancellationToken
	);

}
