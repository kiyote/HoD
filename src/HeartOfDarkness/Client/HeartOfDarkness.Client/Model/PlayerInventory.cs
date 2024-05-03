namespace HeartOfDarkness.Client.Model;

public record PlayerInventory {

	private readonly Dictionary<string, int> _resources;

	public PlayerInventory() {
		_resources = [];
	}

	public int this[string resourceId] {
		get {
			return _resources[resourceId];
		}
		set {
			_resources[resourceId] = value;
		}
	}
}
