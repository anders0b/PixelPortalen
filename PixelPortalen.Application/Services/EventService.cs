using System.Net.Http.Json;
using PixelPortalen.Application.Interfaces;
using PixelPortalen.Domain.Entities;

namespace PixelPortalen.WebApp.Services;

public class EventService : IEventService<EventEntity>
{
    private readonly HttpClient _httpClient;

    public EventService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient("api");
    }
    public async Task<IEnumerable<EventEntity>> GetAllAsync()
    {
        var response = await _httpClient.GetAsync("api/event");
        if (!response.IsSuccessStatusCode)
        {
            return Enumerable.Empty<EventEntity>();
        }
        var result = await response.Content.ReadFromJsonAsync<List<EventEntity>>();
        return result;
    }

    public async Task<EventEntity?> GetByIdAsync(string id)
    {
        var response = await _httpClient.GetAsync($"api/event/{id}");
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        var result = await response.Content.ReadFromJsonAsync<EventEntity>();
        return result;
    }

    public async Task<IEnumerable<EventEntity>?> GetByUserIdAsync(string id)
    {
        var response = await _httpClient.GetAsync($"api/event/user/{id}");
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        var result = await response.Content.ReadFromJsonAsync<List<EventEntity>>();
        return result;
    }

    public async Task AddAsync(EventEntity newEvent)
    {
        var response = await _httpClient.PostAsJsonAsync($"api/event", newEvent);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Failed to add event");
        }
    }

    public async Task UpdateAsync(EventEntity newEvent)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/event", newEvent);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Failed to update event");
        }
    }

    public async Task UpdateUserToEvent(EventEntity newEvent)
    {
        var response = await _httpClient.PatchAsJsonAsync("api/event", newEvent);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Failed to update event");
        }
    }

    public async Task DeleteAsync(string id)
    {
        var response = await _httpClient.DeleteAsync($"api/event/{id}");
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Failed to delete event");
        }
    }
}