using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheKitchenMess.Models
{
    [Serializable]
    public class AnalyzedInstructions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("steps")]
        public List<Step>? Steps { get; set; }
    }
}