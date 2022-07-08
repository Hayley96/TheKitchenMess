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

            return _recipeManagementService!.SearchRecipes() ? (ActionResult<IEnumerable<Root>>)_recipeManagementService.GetRecipes() : (ActionResult<IEnumerable<Root>>)BadRequest();
        }

        [HttpGet("{ingredients}")]
        // GET: api/v1/recipe/ingredients
        public ActionResult<IEnumerable<Root>> GetRecipesByIngredients(string ingredients)
        {
            return _recipeManagementService!.SearchRecipesByIngredients(ingredients) ? (ActionResult<IEnumerable<Root>>)_recipeManagementService.GetRecipes() : (ActionResult<IEnumerable<Root>>)BadRequest();
        }

        [HttpGet("{ingredients}, {exIngredients}")]
        // GET: api/v1/recipe/ingredients, exIngredients
        public ActionResult<IEnumerable<Root>> GetRecipesByIngredientsAndExIngredietns(string ingredients, string exIngredients)
        {
            return _recipeManagementService!.SearchRecipesByIngredientsAndExIngredients(ingredients, exIngredients)
                ? (ActionResult<IEnumerable<Root>>)_recipeManagementService.GetRecipes()
                : (ActionResult<IEnumerable<Root>>)BadRequest();
        }
    }
}