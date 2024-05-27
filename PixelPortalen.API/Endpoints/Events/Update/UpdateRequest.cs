using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Events.Update;

public class UpdateRequest
{
    [FromBody]
    public EventDocument Event { get; set; }
}