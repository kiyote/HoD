namespace HeartOfDarkness.Client.Data {
	internal sealed class SystemRandom : IRandom {
		private readonly Random _random;

		public SystemRandom() {
			_random = new Random();
		}

		int IRandom.Roll(
			DieType dieType,
			int modifier,
			int min,
			int max
		) {
			int result = dieType switch {
				DieType.D6 => _random.Next( 1, 7 ),
				DieType.D10 => _random.Next( 1, 11 ),
				_ => throw new ArgumentOutOfRangeException( nameof( dieType ), dieType, null )
			};
			result += modifier;
			if( result < min ) {
				result = min;
			}
			if( result > max ) {
				result = max;
			}
			return result;
		}
	}
}
