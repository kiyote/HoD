namespace HeartOfDarkness.Client.Data;

internal sealed class StaticGameDefinitionFactory : IGameDefinitionFactory {
	public static readonly Guid Id = new Guid( "52b5a1e52fab435c992cdd928b9a67ef" );
	private readonly IPlayerColourDefinitionProvider _playerColourDefinitionProvider;
	private readonly IMapDefinitionProvider _mapDefinitionProvider;
	private readonly IMatrixDefinitionProvider _matrixDefinitionProvider;
	private readonly IPatronDefinitionProvider _patronDefinitionProvider;
	private readonly IResourceDefinitionProvider _resourceDefinitionProvider;
	private readonly IInventoryResourceDefinitionProvider _inventoryResourceDefinitionProvider;

	public StaticGameDefinitionFactory(
		IPlayerColourDefinitionProvider playerColourDefinitionProvider,
		IMapDefinitionProvider mapDefinitionProvider,
		IMatrixDefinitionProvider matrixDefinitionProvider,
		IPatronDefinitionProvider patronDefinitionProvider,
		IResourceDefinitionProvider resourceDefinitionProvider,
		IInventoryResourceDefinitionProvider inventoryResourceDefinitionProvider
	) {
		_playerColourDefinitionProvider = playerColourDefinitionProvider;
		_mapDefinitionProvider = mapDefinitionProvider;
		_matrixDefinitionProvider = matrixDefinitionProvider;
		_patronDefinitionProvider = patronDefinitionProvider;
		_resourceDefinitionProvider = resourceDefinitionProvider;
		_inventoryResourceDefinitionProvider = inventoryResourceDefinitionProvider;
	}

	async Task<GameDefinition> IGameDefinitionFactory.CreateAsync(
		CancellationToken cancellationToken
	) {
		IReadOnlyList<PlayerColourDefinition> playerColourDefinitions = await _playerColourDefinitionProvider.GetAsync(
			cancellationToken
		);
		MapDefinition mapDefinition = await _mapDefinitionProvider.GetAsync(
			cancellationToken
		);
		MatrixDefinition matrixDefinition = await _matrixDefinitionProvider.GetAsync(
			cancellationToken
		);
		IReadOnlyList<PatronDefinition> patronDefinitions = await _patronDefinitionProvider.GetAsync(
			cancellationToken
		);
		IReadOnlyList<ResourceDefinition> resourceDefinitions = await _resourceDefinitionProvider.GetAsync(
			cancellationToken
		);
		IReadOnlyList<InventoryResourceDefinition> inventoryResourceDefinitions = await _inventoryResourceDefinitionProvider.GetAsync(
			cancellationToken
		);

		return new GameDefinition(
			Id,
			mapDefinition,
			matrixDefinition,
			playerColourDefinitions,
			patronDefinitions,
			resourceDefinitions,
			inventoryResourceDefinitions
		);
	}
}
