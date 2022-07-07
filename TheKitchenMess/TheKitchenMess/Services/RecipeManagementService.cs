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

        public HttpResponseMessage GetSpoonacular(string parameters)
        {
            var url = $"https://api.spoonacular.com/recipes/complexSearch";
       
            using var client = new HttpClient();
            client.BaseAddress = new(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client.GetAsync(parameters).Result;
        }

        public List<Root> GetAllRecipes()
        {
            /* default parameters, ** are non-nullable
             * addRecipeInformation=true
             ** maxReadyTime=90
             * ignorePantry=true
             * sort=max-used-ingredient or meta-score, popularity
             ** maxCalories=1200
             */

            string parameters = $"?cuisine=&diet=&intolerances=&includeIngredients=&excludeIngredients=" +
              $"&type=&addRecipeInformation=true&maxReadyTime=90&ignorePantry=true&sort=max-used-ingredients&maxCalories=1200&number=1&apiKey={APIKey}";

            HttpResponseMessage response = GetSpoonacular(parameters);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                var recipeList = JsonConvert.DeserializeObject<Root>(jsonString);

                recipes.Add(recipeList);
                //Create(recipeList);  --This is a method I have that writes to the database - not included here yet
            }

            return recipes;
        }

        public List<Root> GetRecipesByIngredients(string ingredients)
        {

            string parameters = $"?cuisine=&diet=&intolerances=&includeIngredients={ingredients}&excludeIngredients=" +
              $"&type=&addRecipeInformation=true&maxReadyTime=90&ignorePantry=true&sort=max-used-ingredients&maxCalories=1200&number=1&apiKey={APIKey}";

            HttpResponseMessage response = GetSpoonacular(parameters);

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