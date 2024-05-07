namespace HeartOfDarkness.Client.Data;

public static class ExtensionMethods {

	public static IServiceCollection AddData(
		this IServiceCollection services
	) {
		return services
			.AddSingleton<IMapDefinitionProvider, StaticMapDefinitionProvider>()
			.AddSingleton<IGameFactory, GameFactory>()
			.AddSingleton<IMapStateFactory, MapStateFactory>()
			.AddSingleton<IPatronDefinitionProvider, StaticPatronDefinitionProvider>()
			.AddSingleton<IResourceDefinitionProvider, StaticResourceDefinitionProvider>()
			.AddSingleton<IPlayerColourDefinitionProvider, StaticPlayerColourDefinitionProvider>()
			.AddSingleton<IInventoryResourceDefinitionProvider, StaticInventoryResourceDefinitionProvider>()
			.AddSingleton<IPorterCapacityProvider, PorterCapacityProvider>()
			.AddSingleton<IResourceLimitProvider, ResourceLimitProvider>();
	}
}
