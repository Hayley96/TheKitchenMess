using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public interface IRecipeManagementService
    {
        List<Root> GetRecipes();
        bool SearchRecipes();
        bool SearchRecipesByIngredients(string ingredients);
        bool SearchRecipesByIngredientsAndExIngredients(string ingredients, string exIngredients);

    }
}
