namespace PixelPortalen.Domain.Entities;

public class OrderEntity
{
    public string Id { get; set; }
    public Guid UserId { get; set; } = Guid.Empty;
    public List<OrderItemEntity> OrderItems { get; set; } = new();
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public bool Open { get; set; }
}