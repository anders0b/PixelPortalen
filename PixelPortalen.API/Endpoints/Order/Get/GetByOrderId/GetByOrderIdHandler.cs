using FastEndpoints;
using PixelPortalen.API.Endpoints.Order.Get.GetByUserId;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Order.Get.GetByOrderId;

public class GetByOrderIdHandler(OrderRepository repo) : Endpoint<GetByOrderIdRequest, OrderDocument>
{
    public override void Configure()
    {
        Get("/api/order/{OrderId}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetByOrderIdRequest req, CancellationToken ct)
    {
        var order = await repo.GetByIdAsync(req.OrderId);
        await SendAsync(order, cancellation: ct);
    }


}