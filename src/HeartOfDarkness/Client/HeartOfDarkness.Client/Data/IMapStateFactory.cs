namespace HeartOfDarkness.Client.Data;

public interface IMapStateFactory {

	Task<MapState> CreateAsync(
		MapDefinition definition,
		CancellationToken cancellationToken
	);

}
