using System.Text.Json.Serialization;

namespace FoodFusion.Server.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PaymentStatus
    {
        Pending = 1,
        Completed = 6,
        Faild = 7,
        Refunded = 10,
    }
}
