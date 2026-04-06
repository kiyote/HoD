namespace HeartOfDarkness.Client.Data;

internal sealed class LogLineProvider : ILogLineProvider {

	private readonly IMapDefinitionProvider _mapDefinitionProvider;

	public LogLineProvider(
		IMapDefinitionProvider mapDefinitionProvider
	) {
		_mapDefinitionProvider = mapDefinitionProvider;
	}

	async Task<string> ILogLineProvider.StartExpeditionAsync(
		string startingRegionId,
		CancellationToken cancellationToken
	) {
		MapDefinition mapDefinition = await _mapDefinitionProvider.GetAsync( cancellationToken );
		RegionDefinition region = mapDefinition.Regions.First( r => r.Id == startingRegionId );
		return $"Expedition started in {region.Id}.";
	}
}
