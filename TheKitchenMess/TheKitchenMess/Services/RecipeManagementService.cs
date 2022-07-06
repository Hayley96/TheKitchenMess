using Newtonsoft.Json;
using System.Net.Http.Headers;
using TheKitchenMess.Models;

namespace TheKitchenMess.Services
{
    public class RecipeManagementService : IRecipeManagementService
    {
        private readonly ModelsContext _context;
        private readonly string? APIKey = Environment.GetEnvironmentVariable("SpoonacularKey");
        private readonly List<Root> recipes = new();
        public RecipeManagementService(ModelsContext context)
        {
            _context = context;
        }

        public List<Root> GetAllRecipes()
        {
            //var recipes = _context.RecipeRoot!.ToList();

            int offset = 0;
            string cuisine = "italian";
            string diet = "vegetarian";
            string includeIngredients = "tomato,cheese";
            string excludeIngredients = "eggs";
            bool addRecipeInformation = true, limitLicense = true;

            var url = $"https://api.spoonacular.com/recipes/complexSearch";

            var parameters = $"?cuisine={cuisine}&diet={diet}&includeIngredients={includeIngredients}&excludeIngredients={excludeIngredients}" +
                $"&addRecipeInformation={addRecipeInformation}&offset={offset}&number=2&limitLicense={limitLicense}&apiKey={APIKey}";

            using var client = new HttpClient();
            client.BaseAddress = new(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(parameters).Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                var recipeList = JsonConvert.DeserializeObject<Root>(jsonString);

                recipes.Add(recipeList);
                //Create(recipeList);  --This is a method I have that writes to the database - not included here yet
            }

            return recipes;
        }
    }
}