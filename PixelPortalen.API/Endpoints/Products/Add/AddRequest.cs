using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Extensions.Products.Add;

public class AddRequest
{
    [FromBody]
    public ProductDocument ProductDocument { get; set; }
}