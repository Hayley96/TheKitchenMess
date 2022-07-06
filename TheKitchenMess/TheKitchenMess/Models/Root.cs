using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheKitchenMess.Models
{
    [Serializable]
    public class Root
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        //[JsonProperty("results")]
        //public List<Result>? Results { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }
    }
}