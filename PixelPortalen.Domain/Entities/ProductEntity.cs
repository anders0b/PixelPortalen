
using PixelPortalen.Domain.Enums;

namespace PixelPortalen.Domain.Entities;

public class ProductEntity
{
    public string Id { get; set; }
    public long EAN { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public List<Category> Categories { get; set; }
    public Rating Rating { get; set; }
    public List<ReviewEntity> Reviews { get; set; } = new();
    public string Description { get; set; }
    public bool OpenBox { get; set; }
    public GameSystem System { get; set; }
    public int Percentage { get; set; }
    public string ImageUrl { get; set; }

}