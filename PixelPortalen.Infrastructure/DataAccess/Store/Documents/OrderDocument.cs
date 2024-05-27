using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PixelPortalen.Domain;

namespace PixelPortalen.Infrastructure.DataAccess.Store.Documents;

public class OrderDocument : IEntity<string>
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public Guid UserId { get; set; } = Guid.Empty;
    public List<OrderItemDocument> OrderItems { get; set; } = new();
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public bool Open { get; set; }
}