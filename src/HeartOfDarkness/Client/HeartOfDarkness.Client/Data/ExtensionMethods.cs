namespace HeartOfDarkness.Client.Data;

public static class ExtensionMethods {

	public static IServiceCollection AddData(
		this IServiceCollection services
	) {
		return services
			.AddSingleton<IMapDefinitionFactory, StaticMapDefinitionFactory>()
			.AddSingleton<IGameFactory, GameFactory>()
			.AddSingleton<ISavedGameFactory, SavedGameFactory>()
			.AddSingleton<IMapStateFactory, MapStateFactory>()
			.AddSingleton<IPatronDefinitionFactory, StaticPatronDefinitionFactory>()
			.AddSingleton<IResourceDefinitionFactory, StaticResourceDefinitionFactory>();
	}
}
