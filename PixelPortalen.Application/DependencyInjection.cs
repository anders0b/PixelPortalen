using Microsoft.Extensions.DependencyInjection;
using PixelPortalen.Application.Interfaces;
using PixelPortalen.Domain.Entities;
using PixelPortalen.WebApp.Services;

namespace PixelPortalen.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Add all services here
        services.AddScoped<IProductService<ProductEntity>, ProductService>();
        services.AddScoped<IEventService<EventEntity>, EventService>();
        services.AddScoped<IOrderService<OrderEntity>, OrderService>();
        services.AddScoped<ISwishService<SwishEntity>, SwishService>();



        return services;
    }
}