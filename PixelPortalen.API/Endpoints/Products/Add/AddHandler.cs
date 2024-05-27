using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Extensions.Products.Add;

public class AddHandler(ProductRepository repo):Endpoint<AddRequest,AddResponse>
{
    public override void Configure()
    {
        Post("/api/product");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddRequest req, CancellationToken ct)
    {
        await repo.AddAsync(req.ProductDocument);
        await SendAsync(new()
            {
                ProductDocument = req.ProductDocument,
            }
            , cancellation:ct);
        
    }
}