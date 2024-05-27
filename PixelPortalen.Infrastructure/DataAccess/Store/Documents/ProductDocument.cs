using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PixelPortalen.Domain;
using PixelPortalen.Domain.Enums;

namespace PixelPortalen.Infrastructure.DataAccess.Store.Documents;

public class ProductDocument : IEntity<string>
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public long EAN { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public List<Category> Categories { get; set; } = new();
    public Rating Rating { get; set; }
    public List<ReviewDocument> Reviews { get; set; } = new();
    public string Description { get; set; }
    public bool OpenBox { get; set; }
    public GameSystem System { get; set; }
    public int Percentage { get; set; }
    public string ImageUrl { get; set; }
}