using System.Text.Json.Serialization;

namespace FoodFusion.Server.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CancellationStatus
    {
        Pending = 1,
        Approved = 8,
        Rejected = 9,
    }
}
