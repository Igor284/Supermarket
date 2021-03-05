using Supermarket.Domain.Models;
using Supermarket.Models;
namespace Supermarket.Domain.Servises.Interfaces
{
    public interface IProductService
    {
        Product AddProduct(ProductModel model);
    }
}
