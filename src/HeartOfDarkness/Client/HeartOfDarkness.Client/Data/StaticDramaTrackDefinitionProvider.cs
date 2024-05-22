
namespace HeartOfDarkness.Client.Data;

internal sealed class StaticDramaTrackDefinitionProvider : IDramaTrackDefinitionProvider {

	private readonly DramaTrackDefinition _definition = new DramaTrackDefinition(
		[
			new Position(82,1375), // start
			new Position(82,1455), // 1
			new Position(82,1530), // 2
			new Position(82,1605), // 3
			new Position(82,1685), // 4
			new Position(82,1760), // 5
			new Position(82,1840), // 6
			new Position(82,1915), // 7
			new Position(82,1990), // 8
			new Position(82,2065), // 9
			new Position(82,2140), // 10
			new Position(82,2220), // 11
			new Position(82,2290), // 12
			new Position(82,2370), // 13
			new Position(82,2445), // 14
			new Position(82,2520), // 15
			new Position(82,2595), // 16
			new Position(82,2675), // 17
			new Position(82,2750), // 18
			new Position(82,2825), // 19
			new Position(165,2825), // 20
			new Position(165,2745), // 21
			new Position(165,2670), // 22
			new Position(165,2595), // 23
			new Position(165,2520), // 24
			new Position(165,2445), // 25
			new Position(165,2365), // 26
			new Position(165,2290), // 27
			new Position(260,2290), // 28
			new Position(260,2365), // 29
			new Position(260,2440), // 30
			new Position(260,2520), // 31
			new Position(260,2595), // 32
			new Position(260,2670), // 33
			new Position(260,2745), // 34
			new Position(260,2825), // 35
			new Position(350,2825), // 36
			new Position(440,2825), // 37
			new Position(520,2825), // 38
			new Position(610,2825), // 39
			new Position(695,2825), // 40
			new Position(780,2825), // 41
			new Position(870,2825), // 42
			new Position(955,2825), // 43
			new Position(1040,2825), // 44
			new Position(1130,2825), // 45
			new Position(1215,2825), // 46
			new Position(1300,2825), // 47
			new Position(1380,2825), // 48
			new Position(1465,2825), // 49
			new Position(1550,2825), // 50
		]
	);

	Task<DramaTrackDefinition> IDramaTrackDefinitionProvider.GetAsync(
		CancellationToken cancellationToken
	) {
		return Task.FromResult( _definition );
	}
}
