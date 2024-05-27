using MongoDB.Driver;
using PixelPortalen.Application.Interfaces;
using PixelPortalen.Domain.Entities;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.Infrastructure.DataAccess.Store;

public class OrderRepository : IOrderRepository
{
    private readonly IMongoCollection<OrderDocument> _orderCollection;

    public OrderRepository()
    {
        var hostName = "localhost";
        var port = "27017";
        var databaseName = "PixelPortalen";
        var client = new MongoClient("");
        var database = client.GetDatabase(databaseName);
        _orderCollection = database.GetCollection<OrderDocument>("OrderCollection",
            new MongoCollectionSettings() { AssignIdOnInsert = true });
    }
    public async Task AddAsync(OrderDocument entity)
    {
        await _orderCollection.InsertOneAsync(entity);
    }

    public async Task<IEnumerable<OrderDocument>> GetAllAsync()
    {
        var orders = await _orderCollection.Find(t => true).ToListAsync();
        return orders;
    }

    public async Task<OrderDocument> GetByIdAsync(string id)
    {
        var order = await _orderCollection.Find(t => t.Id == id).FirstOrDefaultAsync();
        return order;
    }

    public async Task<IEnumerable<OrderDocument>> GetByUserIdAsync(Guid userId)
    {
        var orders = await _orderCollection.Find(t => t.UserId == userId).ToListAsync();
        return orders;
    }

    public async Task UpdateAsync(OrderDocument entity)
    {
        await _orderCollection.ReplaceOneAsync(t => t.Id == entity.Id, entity);
    }

    public async Task DeleteOrderAsync(string id)
    {
        await _orderCollection.DeleteOneAsync(t => t.Id == id);
    }

    public async Task AddOrderItemAsync(string orderId, OrderItemDocument orderItem)
    {
        var order = await GetByIdAsync(orderId);
        var existingProduct = order.OrderItems.Find(t => t.ProductId == orderItem.ProductId);
        if (existingProduct != null)
        {
            existingProduct.Quantity += orderItem.Quantity;
            await UpdateAsync(order);
            return;
        }
        order.OrderItems.Add(orderItem);
        await UpdateAsync(order);
    }

    public async Task DeleteOrderItemAsync(string orderId, string productId)
    {
        var order = await GetByIdAsync(orderId);
        order.OrderItems.RemoveAll(t => t.ProductId == productId);
        await UpdateAsync(order);
    }

    public async Task UpdateOrderItemAsync(string orderId, OrderItemDocument orderItem)
    {
        var order = await GetByIdAsync(orderId);
        var index = order.OrderItems.FindIndex(t => t.Id == orderItem.Id);
        order.OrderItems[index] = orderItem;
        await UpdateAsync(order);
    }

    public async Task ChangeStatus(string orderId)
    {
        var order = await GetByIdAsync(orderId);
        order.Open = !order.Open;
        await UpdateAsync(order);
    }
    
}