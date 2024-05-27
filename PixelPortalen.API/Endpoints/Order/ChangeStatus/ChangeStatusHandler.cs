using FastEndpoints;
using PixelPortalen.API.Endpoints.Order.Get.GetByOrderId;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Order.ChangeStatus;

public class ChangeStatusHandler(OrderRepository repo) : Endpoint<ChangeStatusRequest, EmptyResponse>
{
    public override void Configure()
    {
        Patch("/api/order/{OrderId}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ChangeStatusRequest req, CancellationToken ct)
    {
        await repo.ChangeStatus(req.order.Id);
        await SendAsync(new EmptyResponse(), cancellation: ct);
    }
}