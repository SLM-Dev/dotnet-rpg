using System.Text.Json.Serialization;

namespace rpg_game_dotnet.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Monk = 1,

        Cleric = 2,

        Bard = 3,
    }
}