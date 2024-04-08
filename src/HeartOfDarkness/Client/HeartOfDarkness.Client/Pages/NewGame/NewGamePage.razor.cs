using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace HeartOfDarkness.Client.Pages.NewGame;

public class NewGamePageBase : ComponentBase {

	private List<Game> _games = [];

	[Inject]
	protected IGameFactory GameFactory { get; set; } = default!;

	[Inject]
	protected ILocalStorageService Storage { get; set; } = default!;

	protected IEnumerable<Game> Games => _games;

	protected override async Task OnAfterRenderAsync(
		bool firstRender
	) {
		if (firstRender) {
			List<Game>? games = await Storage.GetItemAsync<List<Game>?>( "games" ).ConfigureAwait( false );
			_games = games ?? [];
			StateHasChanged();
		}
	}

	protected async Task OnCreateGameClicked() {
		Game game = GameFactory.Create();
		_games.Add( game );
		await Storage.SetItemAsync( "games", _games.ToArray() ).ConfigureAwait( false );

	}
}
