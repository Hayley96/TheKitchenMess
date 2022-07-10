using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public interface IRecipeManagementService
    {
        List<RecipeDTO> GetRecipes();
        bool SearchRecipes();
        bool SearchRecipesByIngredients(string ingredients);
        bool SearchRecipesByIngredientsAndExIngredients(string ingredients, string exIngredients);

    }
}
