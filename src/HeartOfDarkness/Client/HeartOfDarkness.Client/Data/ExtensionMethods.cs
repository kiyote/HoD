namespace HeartOfDarkness.Client.Data;

public static class ExtensionMethods {

	public static IServiceCollection AddData(
		this IServiceCollection services
	) {
		return services
			.AddSingleton<IMapDefinitionFactory, StaticMapDefinitionFactory>();
	}
}
