using OnionTDD.Core.Models;

namespace OnionTDD.Core.Services;

public interface IProductService
{
    List<Product> GetProducts();
}