using Blazored.LocalStorage;
using HeartOfDarkness.Client.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace HeartOfDarkness.Client;

public static class Program {
	public static async Task Main(
		string[] args
	) {
		var builder = WebAssemblyHostBuilder.CreateDefault( args );
		builder.RootComponents.Add<App>( "#app" );
		builder.RootComponents.Add<HeadOutlet>( "head::after" );

		_ = builder
			.Services
				.AddScoped( sp => new HttpClient {
					BaseAddress = new Uri( builder.HostEnvironment.BaseAddress )
				} )
				.AddBlazoredLocalStorage()
				.AddFluxor( opts => opts.ScanAssemblies( typeof( Program ).Assembly ).UseRouting() )
				.AddModel()
				.AddData();

		await builder
			.Build()
			.RunAsync()
			.ConfigureAwait( false );
	}
}
