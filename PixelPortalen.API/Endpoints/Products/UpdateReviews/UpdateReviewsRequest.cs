using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Products.UpdateReviews;

public class UpdateReviewsRequest
{
    [FromBody]
    public ProductDocument Product { get; set; }
}