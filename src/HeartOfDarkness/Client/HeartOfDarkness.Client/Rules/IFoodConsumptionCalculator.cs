namespace HeartOfDarkness.Client.Rules; 

public interface IFoodConsumptionCalculator {
	int ConsumedFood(
		Game game,
		GameDefinition gameDefinition
	);
}
