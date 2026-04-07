namespace HeartOfDarkness.Client.Data;

public interface IRandom {

	int Roll( DieType dieType, int modifier = 0, int min = int.MinValue, int max = int.MaxValue );
}
