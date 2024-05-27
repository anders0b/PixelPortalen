using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Order.Add.AddOrder;

public class AddOrderHandler(OrderRepository repo) : Endpoint<AddOrderRequest, AddOrderResponse>
{
    public override void Configure()
    {
        Post("/api/order");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddOrderRequest req, CancellationToken ct)
    {
        await repo.AddAsync(req.OrderDocument);
        await SendAsync(new() { id = req.OrderDocument.Id}
                   , cancellation:ct);
        
    }
}
