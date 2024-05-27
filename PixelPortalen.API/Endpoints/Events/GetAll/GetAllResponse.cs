using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Events.GetAll;

public class GetAllResponse
{
    public List<EventDocument> EventDocuments { get; set; }
}