using Microsoft.JSInterop;

namespace HeartOfDarkness.Client.Pages;

public partial class MapComponent : ComponentBase, IAsyncDisposable {

	public enum Style {
		Hidden,
		Selectable
	}

	[Inject]
	public IJSRuntime JS { get; set; } = default!;

	[Parameter]
	public EventCallback OnSetInitialMapState{ get; set; }

	[Parameter]
	public EventCallback<string> OnRegionSelected { get; set; }

	private IJSObjectReference? _module;

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		await base.OnAfterRenderAsync( firstRender );
		if( firstRender) {
			_module = await JS.InvokeAsync<IJSObjectReference>(
				"import",
				"./Pages/MapComponent.razor.js"
			);

			await OnSetInitialMapState.InvokeAsync();
		}
	}


	[JSInvokable]
	public async Task OnRegionClickedAsync(
		string regionId
	) {
		await OnRegionSelected.InvokeAsync( regionId );
	}

	public async ValueTask DisposeAsync() {
		GC.SuppressFinalize( this );
		if (_module is not null) {
			await _module.DisposeAsync();
		}
	}

	public async Task SetRegion(
		string regionId,
		Style style
	) {
		await _module!
			.InvokeVoidAsync(
				"setRegion",
				regionId,
				style.ToString().ToLowerInvariant()
			);
	}
}
