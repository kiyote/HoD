namespace HeartOfDarkness.Client.Data;

internal sealed class MapStateFactory : IMapStateFactory {
	Task<MapState> IMapStateFactory.CreateAsync(
		MapDefinition definition,
		CancellationToken _
	) {
		MapState mapState = new MapState( definition );

		return Task.FromResult( mapState );
	}
}
