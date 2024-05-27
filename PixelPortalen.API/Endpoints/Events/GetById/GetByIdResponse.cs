using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Events.GetById;

public class GetByIdResponse
{
    public EventDocument Event { get; set; }
}