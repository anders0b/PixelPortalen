using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Order.Add.AddOrderItem;

public class AddOrderItemHandler(OrderRepository repo) : Endpoint<AddOrderItemRequest, EmptyResponse>
{
    public override void Configure()
    {
        Post("/api/orderitem");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddOrderItemRequest req, CancellationToken ct)
    {
        await repo.AddOrderItemAsync(req.OrderItemDocument.OrderId, req.OrderItemDocument);
        await SendAsync(new(), cancellation:ct);
        
    }
}
