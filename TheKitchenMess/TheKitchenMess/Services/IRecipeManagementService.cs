using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public interface IRecipeManagementService
    {
        List<RecipeDTO> GetRecipes();
        List<RecipeDTO> GetRecipesByIngredients(string ingredients);

        List<RecipeDTO> GetRecipesByIngredientsAndExIngredients(string ingredients, string exIngredients);

    }
}
