using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Get.GetAllOrder;

public class GetAllOrderResponse
{
    public List<OrderDocument> OrderDocuments { get; set; } = new();
}