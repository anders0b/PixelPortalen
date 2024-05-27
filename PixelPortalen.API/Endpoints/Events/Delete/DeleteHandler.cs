using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Events.Delete;

public class DeleteHandler(EventRepository repo) : Endpoint<DeleteRequest, DeleteResponse>
{
    public override void Configure()
    {
        Delete("/api/event/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteRequest req, CancellationToken ct)
    {
        await repo.DeleteAsync(req.Id);
        await SendAsync(new()
            {
                Id = req.Id,
            }
            , cancellation:ct);
        
    }
}