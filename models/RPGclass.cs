using System.Text.Json.Serialization;

namespace TEST_dotnet.models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGclass
    {
         Knight,
         Mage,
         Priest,
         Assassin,
         Goblin,
    }
}