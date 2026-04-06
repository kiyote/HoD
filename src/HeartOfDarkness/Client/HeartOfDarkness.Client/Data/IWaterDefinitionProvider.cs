namespace HeartOfDarkness.Client.Data {
	public interface IWaterDefinitionProvider {

		Task<IList<WaterDefinition>> GetAsync( CancellationToken cancellationToken );
	}
}
