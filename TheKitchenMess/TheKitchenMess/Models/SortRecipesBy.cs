using System.Text.Json.Serialization;

namespace TheKitchenMess.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortRecipesBy
    {
        meta_score, //meta-score
        popularity,
        healthiness,
        time,
        max_used_ingredients, //max-used-ingredients
        min_missing_ingredients, //min-missing-ingredient
        calories,

    }
}
