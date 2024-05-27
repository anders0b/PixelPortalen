namespace PixelPortalen.Application.Interfaces;

public interface ISwishService<T> where T : class
{
    Task<HttpContent> GetQR(T SwishEntity);

}