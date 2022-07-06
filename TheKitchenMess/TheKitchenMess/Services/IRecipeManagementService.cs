using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public interface IRecipeManagementService
    {
        List<Root> GetAllRecipes();
    }
}
