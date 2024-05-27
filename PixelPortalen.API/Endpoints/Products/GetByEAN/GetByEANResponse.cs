using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Products.GetByEAN;

public class GetByEANResponse
{
    public ProductDocument ProductDocument { get; set; }
}