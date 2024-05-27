namespace PixelPortalen.Application.Interfaces;

public interface IEventService<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(string id);
    Task<IEnumerable<T>> GetByUserIdAsync(string id);
    Task AddAsync(T newEvent);
    Task UpdateAsync(T newEvent);
    Task DeleteAsync(string id);
    Task UpdateUserToEvent(T newEvent);
}