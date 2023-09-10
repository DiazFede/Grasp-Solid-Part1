using Full_GRASP_And_SOLID.Library;

public class ProductionCostCalculator
{
    public double CalculateTotalProductionCost(Recipe recipe)
    {
        double costOfIngredients = CalculateIngredientCost(recipe);
        double equipmentCost = CalculateEquipmentCost(recipe);
        return costOfIngredients + equipmentCost;
    }

    private double CalculateIngredientCost(Recipe recipe)
    {
        double totalIngredientCost = 0;
        foreach (Step step in recipe.GetSteps())
        {
            double ingredientCost = step.Input.CostPerKilogram * step.QuantityInKilograms;
            totalIngredientCost += ingredientCost;
        }
        return totalIngredientCost;
    }

    private double CalculateEquipmentCost(Recipe recipe)
    {
        double totalEquipmentCost = 0;
        foreach (Step step in recipe.GetSteps())
        {
            double equipmentCost = step.Equipment.CostPerMinute * step.TimeInMinutes;
            totalEquipmentCost += equipmentCost;
        }
        return totalEquipmentCost;
    }
}
