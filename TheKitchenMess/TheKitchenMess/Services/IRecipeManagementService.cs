using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public interface IRecipeManagementService
    {
<<<<<<< HEAD
        List<Root> GetRecipes();
        bool SearchRecipes();
        bool SearchRecipesByIngredients(string ingredients);
        bool SearchRecipesByIngredientsAndExIngredients(string ingredients, string exIngredients);
=======
        List<RecipeDTO> GetRecipes();
        List<RecipeDTO> GetRecipesByIngredients(string ingredients);

        List<RecipeDTO> GetRecipesByIngredientsAndExIngredients(string ingredients, string exIngredients);
>>>>>>> 2ae95c583520877d46ce11f3bd1bcb60bd46054a

    }
}
