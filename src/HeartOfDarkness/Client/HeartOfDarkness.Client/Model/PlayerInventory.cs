namespace HeartOfDarkness.Client.Model;

public record PlayerInventory(Dictionary<string, int> Resources) {

	public static readonly PlayerInventory None = new PlayerInventory();

	public PlayerInventory()
		: this([]) {
	}

	public int this[string resourceId] {
		get {
			return Resources[resourceId];
		}
		set {
			Resources[resourceId] = value;
		}
	}
}
