namespace HeartOfDarkness.Client.Data;

public interface IPorterCapacityProvider {

	int GetMaximum(
		PlayerInventory inventory
	);

	int GetAvailable(
		PlayerInventory inventory
	);

}
