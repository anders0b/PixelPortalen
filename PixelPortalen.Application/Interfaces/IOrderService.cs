using PixelPortalen.Domain.Entities;

namespace PixelPortalen.Application.Interfaces;

public interface IOrderService<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> GetByUserIdAsync(string id);
    Task<T> CreateOrderAsync(T newOrder);
    Task<T> GetOrderById(string id);
    Task CreateOrderItemAsync(OrderItemEntity newOrderItem);
    Task DeleteOrderItemAsync(OrderItemEntity orderItem);
    Task DeleteOrderAsync(string id);
    Task ChangeStatus(T order);
}