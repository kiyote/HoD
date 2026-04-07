namespace HeartOfDarkness.Client.Data;

internal sealed class GameFactory : IGameFactory {

	private readonly IMapStateFactory _mapStateFactory;
	private readonly IRandom _random;
	private readonly ILogLineProvider _logLineProvider;

	public GameFactory(
		IMapStateFactory mapStateFactory,
		IRandom random,
		ILogLineProvider logLineProvider
	) {
		_mapStateFactory = mapStateFactory;
		_random = random;
		_logLineProvider = logLineProvider;
	}

	async Task<Game> IGameFactory.CreateNewAsync(
		NewGame newGame,
		GameDefinition gameDefinition,
		CancellationToken cancellationToken
	) {
		if( string.IsNullOrWhiteSpace( newGame.PortOfEntry ) ) {
			throw new ArgumentException( $"{nameof( newGame.PortOfEntry )} must not be null or whitespace.", nameof( newGame ) );
		}
		MapState mapState = await _mapStateFactory.CreateAsync(
			gameDefinition.MapDefinition,
			CancellationToken.None
		);
		PlayerColourDefinition colourDefinition = gameDefinition.PlayerColourDefinitions.First( d => d.Id == newGame.Colour );
		mapState[newGame.PortOfEntry] = mapState[newGame.PortOfEntry] with { Token = colourDefinition.ExplorerToken };

		int disease = _random.Roll( DieType.D6, modifier: -2, min: 1 );
		int horror = disease + 1;

		string startExpeditionLogLine = await _logLineProvider.StartExpeditionAsync(
			gameDefinition.MapDefinition,
			newGame.PortOfEntry,
			cancellationToken
		);

		Player player = new Player(
			newGame.Colour,
			newGame.PortOfEntry ?? throw new InvalidOperationException(),
			0,
			0,
			0,
			newGame.Inventory
		);
		return new Game(
			gameDefinition.Id,
			Guid.NewGuid(),
			player,
			mapState,
			[
				startExpeditionLogLine
			],
			GamePhase.Map,
			disease,
			horror
		);
	}
}
