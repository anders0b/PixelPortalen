using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Events.AddUserToEvent;

public class AddUserToEventRequest
{
    [FromBody]
    public EventDocument Event { get; set; }
}