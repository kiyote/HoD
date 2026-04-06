namespace HeartOfDarkness.Client.Model {
	public sealed record WaterDefinition(
		ImageDefinition Image,
		string Id,
		string Description,
		int DramaPoint,
		int TimePenalty,
		bool IsSource,
		bool BlockBorder,
		string BonusPatronId
	) {
	}
}
