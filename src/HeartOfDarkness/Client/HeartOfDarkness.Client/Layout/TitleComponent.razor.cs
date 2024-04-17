using Fluxor.Blazor.Web.Components;
using HeartOfDarkness.Client.Store;
using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Layout;

public partial class TitleComponent: FluxorComponent {

	[Inject]
	protected IState<TitleState> State { get; set; } = default!;
}
