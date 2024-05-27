using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Order.Delete.DeleteOrderItem;

public class DeleteOrderItemHandler(OrderRepository repo) : Endpoint<DeleteOrderItemRequest, EmptyResponse>
{
    public override void Configure()
    {
        Delete("/api/orderitem/{OrderId}/{ProductId}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteOrderItemRequest req, CancellationToken ct)
    {
        await repo.DeleteOrderItemAsync(req.OrderId, req.ProductId);
        await SendAsync(new(), cancellation:ct);
        
    }
}