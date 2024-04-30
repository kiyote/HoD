namespace HeartOfDarkness.Client.Model;

public record PlayerInventory(
	int Askari,
	int Porter,
	int Ammo,
	int Gift,
	int Food
) {
	public static readonly PlayerInventory None = new PlayerInventory( 0, 0, 0, 0, 0 );

	public PlayerInventory()
		:this(1, 1, 1, 5, 10)
	{
	}
}
