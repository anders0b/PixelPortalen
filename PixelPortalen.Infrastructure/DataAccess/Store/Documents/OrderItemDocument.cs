using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace PixelPortalen.Infrastructure.DataAccess.Store.Documents;

public class OrderItemDocument
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public int Quantity { get; set; }
}