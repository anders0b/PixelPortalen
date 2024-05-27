namespace PixelPortalen.Application.Interfaces;

public interface IProductService<T> where T : class
{
    Task<IEnumerable<T>> GetAllProducts();
    Task<T?> GetProduct(long input);
    Task ChangeStatus(int input);
    Task RemoveProduct(string input);
    Task UpdateProduct(T newProduct);
    Task AddProduct(T newProduct);
    Task<T?> GetProductById(string id);
    Task UpdateReviewsAsync(T newProduct);
    
}