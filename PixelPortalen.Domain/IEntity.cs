namespace PixelPortalen.Domain;

public interface IEntity<T>
{
    T Id { get; set; }
}