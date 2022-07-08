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

        public RecipeManagementController(IRecipeManagementService? recipeManagementService)
        {
            _recipeManagementService = recipeManagementService;
        }


        [HttpGet]
        //GET: api/v1/recipe
        public ActionResult<IEnumerable<RecipeDTO>> GetRecipes()
        {
            return _recipeManagementService!.GetRecipes();
        }

        [HttpGet("{ingredients}")]
        // GET: api/v1/recipe/ingredients
        public ActionResult<IEnumerable<RecipeDTO>> GetRecipesByIngredients(string ingredients)
        {
            return _recipeManagementService!.GetRecipesByIngredients(ingredients);
        }

        [HttpGet("{ingredients}, {exIngredients}")]
        // GET: api/v1/recipe/ingredients, exIngredients
        public ActionResult<IEnumerable<RecipeDTO>> GetRecipesByIngredientsAndExIngredietns(string ingredients, string exIngredients)
        {
            return _recipeManagementService!.GetRecipesByIngredientsAndExIngredients(ingredients, exIngredients);
        }
    }
}