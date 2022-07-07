using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
namespace TheKitchenMess.Models
{
    [Serializable]
    public class Nutrition
    {
        [JsonProperty("nutrients")]
        public List<Nutrient>? Nutrients { get; set; }
    }
}
