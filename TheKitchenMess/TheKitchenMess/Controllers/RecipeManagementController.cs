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
        public ActionResult<IEnumerable<Root>> GetRecipes()
        {
            // return _recipeManagementService!.SearchRecipes();

            if (_recipeManagementService!.SearchRecipes())
                return _recipeManagementService.GetRecipes();

            return BadRequest();

        }

        [HttpGet("{ingredients}")]
        // GET: api/v1/recipe/ingredients
        public ActionResult<IEnumerable<Root>> GetRecipesByIngredients(string ingredients)
        {
            if (_recipeManagementService!.SearchRecipesByIngredients(ingredients))
                return _recipeManagementService.GetRecipes();

            return BadRequest();
        }

        [HttpGet("{ingredients}, {exIngredients}")]
        // GET: api/v1/recipe/ingredients, exIngredients
        public ActionResult<IEnumerable<Root>> GetRecipesByIngredientsAndExIngredietns(string ingredients, string exIngredients)
        {
            if (_recipeManagementService!.SearchRecipesByIngredientsAndExIngredients(ingredients, exIngredients))
                return _recipeManagementService.GetRecipes();

            return BadRequest();
        }
    }
}