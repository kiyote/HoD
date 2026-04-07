namespace HeartOfDarkness.Client.Model;

public static class ExtensionMethods {

	public static IServiceCollection AddModel(
		this IServiceCollection services
	) {

		return services;
	}

	public static string[] ToXY(
		this string location
	) {
		string[] coords = location.Split( ',' );
		if( coords.Length != 2 ) {
			throw new InvalidOperationException( $"Location not contain valid coordinates: `{location}`" );
		}
		return coords;
	}
}
