using PixelPortalen.Infrastructure.DataAccess.Store;
using FastEndpoints;

namespace PixelPortalen.API.Endpoints.Products.UpdateReviews;

public class UpdateReviewsController(ProductRepository repo) : Endpoint<UpdateReviewsRequest, UpdateReviewsResponse>
{
    public override void Configure()
    {
        Patch("/api/product/reviews");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateReviewsRequest req, CancellationToken ct)
    {
        await repo.UpdateReviewsAsync(req.Product);
        await SendAsync(new()
        {
                Id = req.Product.Id,
            }
                   , cancellation: ct);

    }
}