using OnionTDD.Core.Models;

namespace OnionTDD.Domain.Repositories;

public interface IProductRepository
{
    List<Product> FindAll();
}