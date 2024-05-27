using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Events.GetEventByUserId;

public class GetEventByUserIdHandler(EventRepository repo) : Endpoint<GetEventByUserIdRequest, List<EventDocument>>
{
    public override void Configure()
    {
        Get("/api/event/user/{UserId}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetEventByUserIdRequest req, CancellationToken ct)
    {
        var events = await repo.GetByUserIdAsync(req.UserId);
        await SendAsync(events.ToList(), cancellation:ct);
    }

 
}