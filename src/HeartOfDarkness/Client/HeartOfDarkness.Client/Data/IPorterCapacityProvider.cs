namespace HeartOfDarkness.Client.Data;

public interface IPorterCapacityProvider {

	int GetMaximum();

	int GetAvailable();

}
