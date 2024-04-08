namespace HeartOfDarkness.Rules;

public static class ExtensionMethods {

	public static IServiceCollection AddRules(
		this IServiceCollection services
	) {
		return services
			.AddSingleton<IGameFactory, GameFactory>();
	}
}
