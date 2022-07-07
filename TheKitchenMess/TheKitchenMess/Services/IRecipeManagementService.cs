using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public interface IRecipeManagementService
    {
        List<Root> GetRecipes();
        List<Root> GetRecipesByIngredients(string ingredients);

        List<Root> GetRecipesByIngredientsAndExIngredients(string ingredients, string exIngredients);

    }
}
