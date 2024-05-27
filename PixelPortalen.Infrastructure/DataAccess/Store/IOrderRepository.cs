using PixelPortalen.Application.Interfaces;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.Infrastructure.DataAccess.Store;

public interface IOrderRepository : IGenericRepository<OrderDocument, string>
{
    
}