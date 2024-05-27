using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Add.AddOrderItem;

public class AddOrderItemRequest
{
    [FromBody]
    public OrderItemDocument OrderItemDocument { get; set; }
}