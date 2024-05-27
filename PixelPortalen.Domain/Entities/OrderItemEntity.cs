namespace PixelPortalen.Domain.Entities;

public class OrderItemEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public int Quantity { get; set; }
}