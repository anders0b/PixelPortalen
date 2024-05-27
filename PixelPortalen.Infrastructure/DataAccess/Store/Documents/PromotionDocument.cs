namespace PixelPortalen.Infrastructure.DataAccess.Store.Documents;

public class PromotionDocument
{
    public int PercentageOff { get; set; }
    public string PromotionDescription { get; set; }
    public DateTime DateTime { get; set; } = DateTime.Now;
}