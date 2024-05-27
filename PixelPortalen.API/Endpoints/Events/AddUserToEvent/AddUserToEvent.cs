using System.Net;
using FastEndpoints;
using MongoDB.Driver.Core.Operations;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Events.AddUserToEvent;

public class AddUserToEvent(EventRepository repo) : Endpoint<AddUserToEventRequest, AddUserToEventResponse>
{
    public override void Configure()
    {
        Patch("/api/event");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddUserToEventRequest req, CancellationToken ct)
    {
        await repo.AddUserToEvent(req.Event);
        await SendAsync(new()
            {
                Id = req.Event.Id,
            }
            , cancellation: ct);

    }
}