using HeartOfDarkness.Client.Data;

namespace HeartOfDarkness.Client.Rules;

public class GameRules {
	private readonly IRandom _random;

	public GameRules(
		IRandom random
	) {
		_random = random;
	}

	public void StartOfMapPhase(
		Game game,
		GameDefinition gameDefinition
	) {

		int disease = _random.Roll( DieType.D6, modifier: -2, min: 1 );
		int horror = disease + 1;
	}
}
