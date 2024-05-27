using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Products.GetByEAN;

public class GetByEANHandler(ProductRepository repo) : Endpoint<GetByEANRequest, GetByEANResponse>
{
    public override void Configure()
    {
        Get("/api/product/ean/{EAN}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetByEANRequest req, CancellationToken ct)
    {
        
        var product = await repo.GetByEANAsync(req.EAN);
        await SendAsync(new (){ProductDocument = product}, cancellation:ct);

    }
    
}