using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Get.GetByUserId;

public class GetByUserIdHandler(OrderRepository repo): Endpoint<GetByUserIdRequest, List<OrderDocument>>
{
    public override void Configure()
    {
        Get("/api/order/user/{UserId}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetByUserIdRequest req, CancellationToken ct)
    {
        var orders = await repo.GetByUserIdAsync(req.UserId);
        await SendAsync(orders.ToList(), cancellation:ct);
    }

 
}