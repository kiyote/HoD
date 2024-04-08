namespace HeartOfDarkness.Rules;

public interface IGameFactory {
	Game Create();
}

internal sealed class GameFactory: IGameFactory {

	Game IGameFactory.Create() {
		return new Game(
			Guid.NewGuid(),
			[]
		);
	}
}
