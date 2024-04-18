using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages;

public partial class MapComponent : ComponentBase, IAsyncDisposable {

	public enum Style {
		Hidden,
		Selectable
	}

	[Inject]
	public IJSRuntime JS { get; set; } = default!;

	private IJSObjectReference? _module;

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if (firstRender) {
			_module = await JS.InvokeAsync<IJSObjectReference>(
				"import",
				"./Pages/MapComponent.razor.js"
			);

			await SetRegion( "khartoum", Style.Selectable );

		}
		await base.OnAfterRenderAsync( firstRender );
	}


	[JSInvokable]
#pragma warning disable CA1822 // Mark members as static
	public Task OnMapAreaClickedAsync() {
		Console.WriteLine( "OnMapAreaClickedAsync" );
		return Task.CompletedTask;
	}
#pragma warning restore CA1822 // Mark members as static

	public async ValueTask DisposeAsync() {
		GC.SuppressFinalize( this );
		if (_module is not null) {
			await _module.DisposeAsync();
		}
	}

	private async Task SetRegion(
		string region,
		Style style
	) {
		await _module!
			.InvokeVoidAsync(
				"setAreaStyle",
				region,
				style.ToString().ToLowerInvariant()
			);
	}
}
