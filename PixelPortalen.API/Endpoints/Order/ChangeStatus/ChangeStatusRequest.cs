using FastEndpoints;
using PixelPortalen.Domain.Entities;

namespace PixelPortalen.API.Endpoints.Order.ChangeStatus;

public class ChangeStatusRequest
{
    public string OrderId { get; set; }
    [FromBody] 
    public OrderEntity order { get; set; }
}