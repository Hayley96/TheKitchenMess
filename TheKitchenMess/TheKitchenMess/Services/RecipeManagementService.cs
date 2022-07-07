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
            //var recipes = _context.RecipeRoot!.ToList();

            int offset = 0;
            string cuisine = "italian";
            string diet = "vegetarian";
            string includeIngredients = "tomato,cheese";
            string excludeIngredients = "eggs";
            bool addRecipeInformation = true, limitLicense = true;

            string parameters = $"?cuisine={cuisine}&diet={diet}&includeIngredients={includeIngredients}&excludeIngredients={excludeIngredients}" +
               $"&addRecipeInformation={addRecipeInformation}&offset={offset}&number=2&limitLicense={limitLicense}&apiKey={APIKey}";

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

            string parameters = $"?cuisine=&diet=&includeIngredients={ingredients}&excludeIngredients=" +
              $"&addRecipeInformation=&offset=&number=2&limitLicense=&apiKey={APIKey}";

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