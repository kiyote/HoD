namespace HeartOfDarkness.Client.Model;

public static class ExtensionMethods {

	public static IServiceCollection AddModel(
		this IServiceCollection services
	) {

		return services
			.AddSingleton<IGameFactory, GameFactory>()
			.AddSingleton<ISavedGameFactory, SavedGameFactory>();
	}
}
