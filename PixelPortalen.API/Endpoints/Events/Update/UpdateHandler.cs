using FastEndpoints;
using MongoDB.Driver.Core.Operations;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Events.Update;

public class UpdateHandler(EventRepository repo) : Endpoint<UpdateRequest, UpdateResponse>
{
    public override void Configure()
    {
        Put("/api/event");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateRequest req, CancellationToken ct)
    {
        await repo.UpdateAsync(req.Event);
        await SendAsync(new()
            {
                Id = req.Event.Id,
            }
            , cancellation:ct);
        
    }
}   
