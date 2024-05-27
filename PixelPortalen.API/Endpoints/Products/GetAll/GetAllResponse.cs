using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Products.GetAll;

public class GetAllResponse //hantera i frontend
{
    public List<ProductDocument> ProductDocuments { get; set; } = new();
}