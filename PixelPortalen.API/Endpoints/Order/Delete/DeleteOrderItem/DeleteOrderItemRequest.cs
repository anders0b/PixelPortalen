using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Delete.DeleteOrderItem;

public class DeleteOrderItemRequest
{
    public string OrderId { get; set; }
    public string ProductId { get; set; }
}