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

            Calories = calories;
            return _recipeManagementService!.SearchRecipes() ? (ActionResult<IEnumerable<RecipeDTO>>)_recipeManagementService.GetRecipes() : (ActionResult<IEnumerable<RecipeDTO>>)BadRequest();
        }

        [HttpGet("{ingredients}")]
        // GET: api/v1/recipe/ingredients
        public ActionResult<IEnumerable<RecipeDTO>> GetRecipesByIngredients(string ingredients, int? calories=null)
        {
            Calories = calories;
            return _recipeManagementService!.SearchRecipesByIngredients(ingredients) ? (ActionResult<IEnumerable<RecipeDTO>>)_recipeManagementService.GetRecipes() : (ActionResult<IEnumerable<RecipeDTO>>)BadRequest();
        }

        [HttpGet("{ingredients}, {exIngredients}")]
        // GET: api/v1/recipe/ingredients, exIngredients
        public ActionResult<IEnumerable<RecipeDTO>> GetRecipesByIngredientsAndExIngredietns(string ingredients, string exIngredients, int? calories=null)
        {
            Calories = calories;
            return _recipeManagementService!.SearchRecipesByIngredientsAndExIngredients(ingredients, exIngredients)
                ? (ActionResult<IEnumerable<RecipeDTO>>)_recipeManagementService.GetRecipes()
                : (ActionResult<IEnumerable<RecipeDTO>>)BadRequest();
        }
    }
}