namespace PixelPortalen.Domain.Entities;

public class ReviewEntity
{
    public int Rating { get; set; }
    public string Comment { get; set; }
    public string ProductId { get; set; }
    public string UserId { get; set; }
}