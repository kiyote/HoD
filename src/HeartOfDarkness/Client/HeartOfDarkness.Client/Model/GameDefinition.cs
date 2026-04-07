namespace HeartOfDarkness.Client.Model;

public sealed record GameDefinition(
	Guid Id,
	MapDefinition MapDefinition,
	MatrixDefinition MatrixDefinition,
	IReadOnlyList<PlayerColourDefinition> PlayerColourDefinitions,
	IReadOnlyList<PatronDefinition> PatronDefinitions,
	IReadOnlyList<ResourceDefinition> ResourceDefinitions,
	IReadOnlyList<InventoryResourceDefinition> InventoryResourceDefinitions
) {

	public static readonly GameDefinition None = new GameDefinition(
		Guid.Empty,
		MapDefinition.None,
		MatrixDefinition.None,
		[],
		[],
		[],
		[]
	);
}
