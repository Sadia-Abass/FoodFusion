using System.Text.Json.Serialization;

namespace FoodFusion.Server.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OrderStatus
    {
        Pending = 1,
        Processing = 2,
        Shipped = 3,
        Delivery = 4,
        Canceled = 5
    }
}
