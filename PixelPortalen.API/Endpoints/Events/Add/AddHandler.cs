using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Events.Add;

public class AddHandler(EventRepository repo) : Endpoint<AddRequest, AddResponse>
{
    public override void Configure()
    {
        Post("/api/event");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddRequest req, CancellationToken ct)
    {
        await repo.AddAsync(req.EventDocument);
        await SendAsync(new()
            {
                EventDocument = req.EventDocument,
            }
                   , cancellation:ct);
        
    }
}