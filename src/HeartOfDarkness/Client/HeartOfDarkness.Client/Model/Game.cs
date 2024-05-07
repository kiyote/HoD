using System.Text.Json.Serialization;

namespace HeartOfDarkness.Client.Model;

public sealed record Game(
	Guid Id,
	Player Player,
	MapState MapState,
	[property:JsonIgnore] MapDefinition MapDefinition
) {
	public static readonly Game None = new Game( Guid.Empty, Player.None, MapState.None, MapDefinition.None );
}
