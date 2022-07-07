using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
namespace TheKitchenMess.Models
{
    [Serializable]
    public class Nutrient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }
}
