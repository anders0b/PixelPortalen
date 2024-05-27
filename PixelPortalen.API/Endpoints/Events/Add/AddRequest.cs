using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Events.Add;

public class AddRequest
{
    [FromBody]
    public EventDocument EventDocument { get; set; }
}