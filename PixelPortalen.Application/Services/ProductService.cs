using System.Net.Http;
using System.Net.Http.Json;
using PixelPortalen.Application.Interfaces;
using PixelPortalen.Domain.Entities;


namespace PixelPortalen.WebApp.Services;

public class ProductService : IProductService<ProductEntity>
{
    private readonly HttpClient _httpClient;

    public ProductService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("api");
    }
    public async Task<IEnumerable<ProductEntity>> GetAllProducts()
    {
        var response = await _httpClient.GetAsync("api/product");
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<ProductEntity>();
        }

        var result = await response.Content.ReadFromJsonAsync<List<ProductEntity>>();
        return result;
    }

    public async Task<ProductEntity?> GetProduct(long input)
    {
        var response = await _httpClient.GetAsync($"api/product/{input}");
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var result = await response.Content.ReadFromJsonAsync<ProductEntity>();
        return result;
    }

    public Task ChangeStatus(int input)
    {
        throw new NotImplementedException();
    }
    public Task UpdateProduct(ProductEntity newProduct)
    {
        throw new NotImplementedException();
    }

    public Task RemoveProduct(string input)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateReviewsAsync(ProductEntity newProduct)
    {
        var response = await _httpClient.PatchAsJsonAsync("api/product/reviews/", newProduct);
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Failed to update product: {response.ReasonPhrase}");
        }
    }

    public async Task AddProduct(ProductEntity newProduct)
    {
        var response = await _httpClient.PostAsJsonAsync($"api/product", newProduct);
        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine("Success  to add product");
            throw new HttpRequestException($"Failed to add product: {response.ReasonPhrase}");
        }
        
    }

    public async Task<ProductEntity?> GetProductById(string id)
    {
        var response = await _httpClient.GetAsync($"api/product/id/{id}");
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        var result = await response.Content.ReadFromJsonAsync<ProductEntity>();
        return result;
    }
}