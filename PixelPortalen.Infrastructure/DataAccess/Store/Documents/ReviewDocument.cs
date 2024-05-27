namespace PixelPortalen.Infrastructure.DataAccess.Store.Documents;

public class ReviewDocument
{
    public int Rating { get; set; }
    public string Comment { get; set; }
    public string ProductId { get; set; }
    public string UserId { get; set; }
}