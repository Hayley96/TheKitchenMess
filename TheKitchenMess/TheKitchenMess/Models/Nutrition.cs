using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
namespace TheKitchenMess.Models
{
    [Serializable]
    public class Nutrition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [JsonProperty("nutrients")]
        public List<Nutrient>? Nutrients { get; set; }
    }
}