using System.Text;
using PixelPortalen.Application.Interfaces;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.Infrastructure.DataAccess.Store;

public interface IProductRepository : IGenericRepository<ProductDocument, string>
{
    Task <ProductDocument> GetByEANAsync(long EAN);
}