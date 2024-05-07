namespace HeartOfDarkness.Client.Data;

internal sealed class MapStateFactory : IMapStateFactory {
	Task<MapState> IMapStateFactory.CreateAsync(
		MapDefinition mapDefinition,
		CancellationToken _
	) {
		MapState mapState = new MapState();
		foreach( RegionDefinition definition in mapDefinition.Regions ) {
			mapState.Regions[definition.Id] = new RegionState( definition.Id, RegionStyle.Hidden );
		}

		return Task.FromResult( mapState );
	}
}
