using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Events.GetAll;

public class GetAllHandler(EventRepository repo) : Endpoint<EmptyRequest, List<EventDocument>>
{
    public override void Configure()
    {
        Get("/api/event");
        AllowAnonymous();
    }

    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {
        var events = await repo.GetAllAsync();
        await SendAsync(events.ToList());
    }
}   
