using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheKitchenMess.Models
{
    [Serializable]
    public class Step
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("step")]
        public string? StepName { get; set; }

        [JsonProperty("ingredients")]
        public List<Ingredient>? Ingredients { get; set; }

        [JsonProperty("equipment")]
        public List<Equipment>? Equipment { get; set; }
    }
}
