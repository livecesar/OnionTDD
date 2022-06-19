using OnionTDD.Core.Models;
using OnionTDD.Core.Services;
using OnionTDD.Domain.Repositories;

namespace OnionTDD.Domain.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        if (repository == null)
        {
            throw new InvalidDataException("Null repository passed to the product service.");
        }
        _repository = repository;
    }
    public List<Product> GetProducts()
    {
        return _repository.FindAll();
        
    }
}