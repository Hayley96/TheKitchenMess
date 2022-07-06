using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public class RecipeManagementService : IRecipeManagementService
    {
        private readonly ModelsContext _context;
        public RecipeManagementService(ModelsContext context)
        {
            _context = context;
        }

        public List<Root> GetAllRecipes()
        {
            var recipes = _context.RecipeRoot!.ToList();
            return recipes;
        }
    }
}