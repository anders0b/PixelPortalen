using System.Transactions;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PixelPortalen.Domain;

namespace PixelPortalen.Infrastructure.DataAccess.Store.Documents;

public class EventDocument : IEntity<string>
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string EventDescription { get; set; }
    public DateTime EventDate { get; set; }
    public List<string> userIds { get; set; } = new();
    public double Price { get; set; }
    public int AvailableSlots { get; set; }
    public PromotionDocument Promotion { get; set; } = new();
    public bool Open { get; set; }
}