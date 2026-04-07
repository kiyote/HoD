namespace HeartOfDarkness.Client.Model;

public sealed record Game(
	Guid GameDefinitionId,
	Guid Id,
	Player Player,
	MapState MapState,
	IList<string> LogLines,
	GamePhase Phase,
	int Disease,
	int Horror
) {
	public static readonly Game None = new Game(
		Guid.Empty,
		Guid.Empty,
		Player.None,
		MapState.None,
		[],
		GamePhase.Unknown,
		0,
		0
	);
}
