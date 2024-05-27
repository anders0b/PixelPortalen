namespace PixelPortalen.Domain.Entities;

public class PromotionEntity
{
    public int PercentageOff { get; set; }
    public string PromotionDescription { get; set; }
    public DateTime DateTime { get; set; } = DateTime.Now;
}