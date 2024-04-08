namespace HeartOfDarkness.Components;

public record Game(
	Guid Id,
	IList<Player> Players
);
