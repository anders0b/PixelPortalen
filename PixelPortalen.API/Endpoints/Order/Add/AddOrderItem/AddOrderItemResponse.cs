using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Add.AddOrderItem;

public class AddOrderItemResponse
{
    public OrderItemDocument OrderItemDocument { get; set; }
}