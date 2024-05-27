using System.Net.Http.Json;
using System.Text.Json;
using PixelPortalen.Application.Interfaces;
using PixelPortalen.Domain.Entities;

namespace PixelPortalen.WebApp.Services;

public class SwishService : ISwishService<SwishEntity>
{
    private readonly HttpClient _httpClient;

    public SwishService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient();
    }
    public async Task<HttpContent> GetQR(SwishEntity SwishEntity)
    {
        var response =
            await _httpClient.PostAsJsonAsync("", SwishEntity);
        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine("Gick inte");
            return null;
        }
        else
        {
           return response.Content;
            
        }

    }
}