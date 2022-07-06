using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheKitchenMess.Models
{
    [Serializable]
    public class Equipment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [JsonProperty("id")]
        public int EquipmentId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("localizedName")]
        public string? LocalizedName { get; set; }

        [JsonProperty("image")]
        public string? Image { get; set; }
    }
}
