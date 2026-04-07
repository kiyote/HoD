namespace HeartOfDarkness.Client.Data;

internal sealed class LogLineProvider : ILogLineProvider {

	async Task<string> ILogLineProvider.StartExpeditionAsync(
		MapDefinition mapDefinition,
		string startingRegionId,
		CancellationToken cancellationToken
	) {
		RegionDefinition region = mapDefinition.Regions.First( r => r.Id == startingRegionId );
		return $"Expedition started in {region.Name}.";
	}
}
