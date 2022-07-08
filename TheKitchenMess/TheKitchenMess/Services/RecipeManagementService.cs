using Newtonsoft.Json;
using System.Net.Http.Headers;
using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public class RecipeManagementService : IRecipeManagementService
    {
        private readonly ModelsContext _context;

        private readonly List<Root> recipes = new();

        private readonly string? APIKey = Environment.GetEnvironmentVariable("SpoonacularKey");

        private  HttpResponseMessage response;

        //parameter to return the max number of recipe 1-100
        private readonly int maxRecipe = 10;

        public RecipeManagementService(ModelsContext context)
        {
            _context = context;
        }

        public HttpResponseMessage CallSpoonacular(string parameters)
        {
            var url = $"https://api.spoonacular.com/recipes/complexSearch";

            using var client = new HttpClient();
            client.BaseAddress = new(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            response = client.GetAsync(parameters).Result;

            return response;
        }

        public List<Root> GetRecipes()
        {
            var jsonString = response.Content.ReadAsStringAsync().Result;
            var recipeList = JsonConvert.DeserializeObject<Root>(jsonString);

            recipes.Add(recipeList);
            //Create(recipeList); 

            return recipes;
        }

        public bool SearchRecipes()
        {
            string sort = nameof(SortRecipesBy.popularity);

            string parameters = $"?cuisine=&diet=&intolerances=&includeIngredients=&excludeIngredients=" +
              $"&type=&addRecipeInformation=true&ignorePantry=true&sort={sort}&number={maxRecipe}&apiKey={APIKey}";

            return CallSpoonacular(parameters).IsSuccessStatusCode;

        }

        public bool SearchRecipesByIngredients(string ingredients)
        {
            string sort = nameof(SortRecipesBy.max_used_ingredients).Replace('_', '-');

            string parameters = $"?cuisine=&diet=&intolerances=&includeIngredients={ingredients}&excludeIngredients=" +
              $"&type=&addRecipeInformation=true&ignorePantry=true&sort={sort}&number={maxRecipe}&apiKey={APIKey}";

            return CallSpoonacular(parameters).IsSuccessStatusCode;
        }

        public bool SearchRecipesByIngredientsAndExIngredients(string ingredients, string exIngredients)
        {
            string sort = nameof(SortRecipesBy.max_used_ingredients).Replace('_', '-');

            string parameters = $"?cuisine=&diet=&intolerances=&includeIngredients={ingredients}&excludeIngredients={exIngredients}" +
              $"&type=&addRecipeInformation=true&ignorePantry=true&sort={sort}&number={maxRecipe}&apiKey={APIKey}";

           return CallSpoonacular(parameters).IsSuccessStatusCode;
        }
    }
}