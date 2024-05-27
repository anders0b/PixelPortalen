namespace PixelPortalen.Domain.Entities;

public class EventEntity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string EventDescription { get; set; }
    public DateTime EventDate { get; set; }
    public List<string> userIds { get; set; } = new();
    public double Price { get; set; }
    public int AvailableSlots { get; set; }
    public PromotionEntity Promotion { get; set; }
    public bool Open { get; set; }
}