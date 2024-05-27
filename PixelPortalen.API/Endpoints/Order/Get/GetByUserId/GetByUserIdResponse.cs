using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Get.GetByUserId;

public class GetByUserIdResponse
{
    public List<OrderDocument> Orders { get; set; } = new();
}