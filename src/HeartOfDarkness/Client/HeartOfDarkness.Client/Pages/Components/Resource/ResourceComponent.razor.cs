﻿using System.Reflection.Metadata;

namespace HeartOfDarkness.Client.Pages.Components.Resource;

public class ResourceComponentBase : ComponentBase {

	[Parameter, EditorRequired]
	public ResourceDefinition Definition { get; set; } = default!;

	[Parameter]
	public int Count { get; set; }

	[Parameter]
	public int Limit { get; set; }

	[Parameter]
	public EventCallback<(string, int)> OnResourceSelected { get; set; }

	protected async Task OnClickHandler(
		string resourceId
	) {
		await OnResourceSelected.InvokeAsync( (resourceId, +1) );
	}

	protected async Task OnSubtractHandler(
		string resourceId
	) {
		await OnResourceSelected.InvokeAsync( (resourceId, -1) );
	}
}
