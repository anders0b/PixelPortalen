using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Get.GetByOrderId;

public class GetByOrderIdResponse
{
    public OrderDocument Order { get; set; }

}