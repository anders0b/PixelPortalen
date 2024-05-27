using PixelPortalen.Application.Interfaces;
using PixelPortalen.Domain.Entities;
using System.Net.Http.Json;
using System.Text.Json;

namespace PixelPortalen.WebApp.Services;

public class OrderService : IOrderService<OrderEntity>
{
    private readonly HttpClient _httpClient;

    public OrderService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("api");
    }
    public async Task<IEnumerable<OrderEntity>> GetAllAsync()
    {
        var response = await _httpClient.GetAsync("api/order");
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<OrderEntity>();
        }
        var result = await response.Content.ReadFromJsonAsync<List<OrderEntity>>();
        return result;
    }

    public async Task<IEnumerable<OrderEntity>> GetByUserIdAsync(string id)
    {
        var response = await _httpClient.GetAsync($"api/order/user/{id}");
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<OrderEntity>();
        }
        var result = await response.Content.ReadFromJsonAsync<List<OrderEntity>>();
        return result;
    }

    public async Task<OrderEntity> CreateOrderAsync(OrderEntity newOrder)
    {
        var response = await _httpClient.PostAsJsonAsync("api/order", newOrder);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        var result = await response.Content.ReadFromJsonAsync<OrderEntity>();
        return result;
        
    }

    public async Task CreateOrderItemAsync(OrderItemEntity newOrderItem)
    {
        var response = await _httpClient.PostAsJsonAsync("api/orderitem", newOrderItem);
    }

    public async Task DeleteOrderItemAsync(OrderItemEntity orderItem)
    {
        var response = await _httpClient.DeleteFromJsonAsync<OrderItemEntity>($"api/orderitem/{orderItem.OrderId}/{orderItem.ProductId}");
    }

    public async Task DeleteOrderAsync(string id)
    {
        throw new NotImplementedException();
    }

    public async Task ChangeStatus(OrderEntity order)
    {
        var response = await _httpClient.PatchAsJsonAsync($"api/order/{order.Id}", order);
        if (!response.IsSuccessStatusCode)
        {
            return;
        }
    }

    public async Task<OrderEntity> GetOrderById(string id)
    {
        var response = await _httpClient.GetAsync($"api/order/{id}");
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        var result = await response.Content.ReadFromJsonAsync<OrderEntity>();
        return result;
    }
}