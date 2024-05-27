using MongoDB.Driver;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.Infrastructure.DataAccess.Store;

public class ProductRepository : IProductRepository
{
    private readonly IMongoCollection<ProductDocument> _productCollection;

    public ProductRepository()
    {
        var hostName = "localhost";
        var port = "27017";
        var databaseName = "PixelPortalen";
        var client = new MongoClient("");
        var database = client.GetDatabase( databaseName );
        _productCollection = database.GetCollection<ProductDocument>("ProductCollection",
            new MongoCollectionSettings() { AssignIdOnInsert = true });
    }

    public async Task AddAsync(ProductDocument entity)
    {
        await _productCollection.InsertOneAsync(entity);
    }

    public async Task<IEnumerable<ProductDocument>> GetAllAsync()
    {
        var products = await _productCollection.Find(t => true).ToListAsync();
        return products;
    }

    public async Task<ProductDocument> GetByEANAsync(long EAN)
    {
        var product = await _productCollection.Find(t => t.EAN == EAN).FirstOrDefaultAsync();
        return product;
    }

    public async Task<ProductDocument> GetByIdAsync(string id)
    {
        var product = await _productCollection.Find(t => t.Id == id).FirstOrDefaultAsync();
        return product;
    }
    public async Task UpdateReviewsAsync(ProductDocument entity)
    {
        var filter = Builders<ProductDocument>.Filter.Eq(s => s.Id, entity.Id);
        var update = Builders<ProductDocument>.Update.Set(s => s.Reviews, entity.Reviews);
        await _productCollection.UpdateOneAsync(filter, update);
    }
}