using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Order.Delete.DeleteOrder;

public class DeleteOrderHandler(OrderRepository repo) : Endpoint<DeleteOrderRequest, EmptyResponse>
{
    public override void Configure()
    {
        Delete("/api/order");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteOrderRequest req, CancellationToken ct)
    {
        await repo.DeleteOrderAsync(req.OrderId);
        await SendAsync(new(), cancellation:ct);
        
    }
}
