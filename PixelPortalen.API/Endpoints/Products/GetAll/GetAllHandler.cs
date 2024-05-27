using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Products.GetAll;

public class GetAllHandler(ProductRepository repo) : Endpoint<EmptyRequest, List<ProductDocument>>
{
    public override void Configure()
    {
        Get("/api/product");
        AllowAnonymous();
    }

    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {
        var products = await repo.GetAllAsync();
        await SendAsync(products.ToList());

    }
}

    