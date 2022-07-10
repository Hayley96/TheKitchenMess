using Microsoft.AspNetCore.Mvc;
using TheKitchenMess.Models;
using TheKitchenMess.Services;

namespace TheKitchenMess.Controllers
{
    [ApiController]
    [Route("ap1/v1/recipe")]
    public class RecipeManagementController : ControllerBase
    {
        private readonly IRecipeManagementService? _recipeManagementService;
        public static int? Calories;

        public RecipeManagementController(IRecipeManagementService? recipeManagementService)
        {
            _recipeManagementService = recipeManagementService;
        }

        [HttpGet]
        //GET: api/v1/recipe
        public ActionResult<IEnumerable<RecipeDTO>> GetRecipes(int? calories=null)
        {
<<<<<<< HEAD
            // return _recipeManagementService!.SearchRecipes();

            return _recipeManagementService!.SearchRecipes() ? (ActionResult<IEnumerable<Root>>)_recipeManagementService.GetRecipes() : (ActionResult<IEnumerable<Root>>)BadRequest();
=======
            Calories = calories;
            return _recipeManagementService!.GetRecipes();
>>>>>>> 2ae95c583520877d46ce11f3bd1bcb60bd46054a
        }

        [FormatFilter]
        [HttpGet("{ingredients}")]
        // GET: api/v1/recipe/ingredients
        public ActionResult<IEnumerable<RecipeDTO>> GetRecipesByIngredients(string ingredients, int? calories=null)
        {
<<<<<<< HEAD
            return _recipeManagementService!.SearchRecipesByIngredients(ingredients) ? (ActionResult<IEnumerable<Root>>)_recipeManagementService.GetRecipes() : (ActionResult<IEnumerable<Root>>)BadRequest();
=======
            Calories = calories;
            return _recipeManagementService!.GetRecipesByIngredients(ingredients);
>>>>>>> 2ae95c583520877d46ce11f3bd1bcb60bd46054a
        }

        [HttpGet("{ingredients}, {exIngredients}")]
        // GET: api/v1/recipe/ingredients, exIngredients
        public ActionResult<IEnumerable<RecipeDTO>> GetRecipesByIngredientsAndExIngredietns(string ingredients, string exIngredients, int? calories=null)
        {
<<<<<<< HEAD
            return _recipeManagementService!.SearchRecipesByIngredientsAndExIngredients(ingredients, exIngredients)
                ? (ActionResult<IEnumerable<Root>>)_recipeManagementService.GetRecipes()
                : (ActionResult<IEnumerable<Root>>)BadRequest();
=======
            Calories = calories;
            return _recipeManagementService!.GetRecipesByIngredientsAndExIngredients(ingredients, exIngredients);
>>>>>>> 2ae95c583520877d46ce11f3bd1bcb60bd46054a
        }
    }
}