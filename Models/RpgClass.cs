using System.Text.Json.Serialization;

namespace dotnetRpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
      Knight,
      Mage,
      Cleric  
    }
}