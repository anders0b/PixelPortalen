using FastEndpoints;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.API.Endpoints.Order.Add.AddOrder;

public class AddOrderRequest
{
    [FromBody]
    public OrderDocument OrderDocument { get; set; }
    
}