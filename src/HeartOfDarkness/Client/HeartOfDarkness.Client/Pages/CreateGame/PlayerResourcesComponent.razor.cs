namespace HeartOfDarkness.Client.Pages.CreateGame;

public class PlayerResourcesComponentBase: ComponentBase {

	[Parameter]
	public IEnumerable<ResourceDefinition> Definitions { get; set; } = default!;

	[Parameter]
	public EventCallback<ResourceDefinition> OnResourceSelected { get; set; }

	[Parameter]
	public IDictionary<string, int> Resources { get; set; } = default!;

	protected Task ResourceSelectedHandler(
		string resourceId
	) {
		ResourceDefinition definition = Definitions.First( d => d.Id == resourceId );
		if (!Resources.ContainsKey(resourceId)) {
			Resources[resourceId] = 0;
		}
		Resources[resourceId] += 1;
		return Task.CompletedTask;
	}
}
