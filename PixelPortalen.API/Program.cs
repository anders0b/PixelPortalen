using FastEndpoints;
using PixelPortalen.API.Extensions;
using PixelPortalen.API.Models;
using PixelPortalen.Infrastructure.DataAccess.Store;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<StoreDatabaseSettings>(builder.Configuration.GetSection("StoreDatabaseSettings"));
builder.Services.AddFastEndpoints();

builder.Services.AddScoped<OrderRepository>();
builder.Services.AddScoped<ProductRepository>();
builder.Services.AddScoped<EventRepository>();

var app = builder.Build();
app.UseFastEndpoints();



app.Run();
