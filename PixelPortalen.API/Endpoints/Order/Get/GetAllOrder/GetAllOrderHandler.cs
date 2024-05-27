using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Get.GetAllOrder;

public class GetAllOrderHandler(OrderRepository repo) : Endpoint<EmptyRequest, List<OrderDocument>>
{
    public override void Configure()
    {
        Get("/api/order");
        AllowAnonymous();
    }

    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {
        var orders = await repo.GetAllAsync();
        await SendAsync(orders.ToList());

    }
}
