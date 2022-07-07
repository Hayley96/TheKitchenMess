using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheKitchenMess.Models
{
    [Serializable]
    public class Result
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [JsonProperty("vegetarian")]
        public bool Vegetarian { get; set; }

        [JsonProperty("vegan")]
        public bool Vegan { get; set; }

        [JsonProperty("glutenFree")]
        public bool GlutenFree { get; set; }

        [JsonProperty("dairyFree")]
        public bool DairyFree { get; set; }
       
        [JsonProperty("lowFodmap")]
        public bool LowFodmap { get; set; }

        [JsonProperty("weightWatcherSmartPoints")]
        public int WeightWatcherSmartPoints { get; set; }

        [JsonProperty("preparationMinutes")]
        public int PreparationMinutes { get; set; }

        [JsonProperty("cookingMinutes")]
        public int CookingMinutes { get; set; }

        [JsonProperty("aggregateLikes")]
        public int AggregateLikes { get; set; }

        [JsonProperty("healthScore")]
        public int HealthScore { get; set; }

        [JsonProperty("license")]
        public string? License { get; set; }

        [JsonProperty("sourceName")]
        public string? SourceName { get; set; }

        [JsonProperty("id")]
        public int Recipeid { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("readyInMinutes")]
        public int ReadyInMinutes { get; set; }

        [JsonProperty("servings")]
        public int Servings { get; set; }

        [JsonProperty("sourceUrl")]
        public string? SourceUrl { get; set; }

        [JsonProperty("openLicense")]
        public int OpenLicense { get; set; }

        [JsonProperty("image")]
        public string? Image { get; set; }

        [JsonProperty("imageType")]
        public string? ImageType { get; set; }

        [JsonProperty("cuisines")]
        public IEnumerable<string>? Cuisines { get; set; }

        [JsonProperty("dishTypes")]
        public IEnumerable<string>? DishTypes { get; set; }

        [JsonProperty("diets")]
        public IEnumerable<string>? Diets { get; set; }

        [JsonProperty("spoonacularSourceUrl")]
        public string? SpoonacularSourceUrl { get; set; }

        [JsonProperty("nutrition")]
        public Nutrition Nutrition { get; set; }
    }
}
