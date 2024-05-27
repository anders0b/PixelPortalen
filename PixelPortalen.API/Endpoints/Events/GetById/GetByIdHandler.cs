using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Events.GetById;

public class GetByIdHandler(EventRepository repo) : Endpoint<GetByIdRequest, EventDocument>
{
    public override void Configure()
    {
        Get("/api/event/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetByIdRequest req, CancellationToken ct)
    {
        var ev = await repo.GetByIdAsync(req.Id);
        await SendAsync( ev, cancellation:ct);
        
    }
}
