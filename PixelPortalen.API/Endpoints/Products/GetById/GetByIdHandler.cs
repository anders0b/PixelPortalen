using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store;

namespace PixelPortalen.API.Endpoints.Products.GetByEAN;

public class GetByIdHandler(ProductRepository repo) : Endpoint<GetByIdRequest, GetByEANResponse>
{
    public override void Configure()
    {
        Get("/api/product/id/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetByIdRequest req, CancellationToken ct)
    {

        var product = await repo.GetByIdAsync(req.Id);
        await SendAsync(new() { ProductDocument = product }, cancellation: ct);

    }

}