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
            return _recipeManagementService!.GetAllRecipes();
        }
    }
}