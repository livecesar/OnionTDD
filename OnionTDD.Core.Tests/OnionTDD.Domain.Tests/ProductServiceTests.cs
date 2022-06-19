using Moq;
using OnionTDD.Core.Models;
using OnionTDD.Core.Services;
using OnionTDD.Domain.Repositories;
using OnionTDD.Domain.Services;

namespace OnionTDD.Domain.Tests;

public class ProductServiceTests
{
    private readonly Mock<IProductRepository> _mock;
    private readonly ProductService _service;
    private readonly List<Product> _expected;

    public ProductServiceTests()
    {
        _mock = new Mock<IProductRepository>();
        _service = new ProductService(_mock.Object);
        
        _expected = new List<Product>
        {
            new Product { ID = 1, Name = "Product One" },
            new Product { ID = 2, Name = "Product Two" },
        };
    }
    
    [Fact]
    public void ProductService_IsIProductService()
    {
        Assert.True(_service is IProductService);
    }

    [Fact]
    public void ProductService_WithNullProductRepository_ThrowsInvalidDataException()
    {
        Assert.Throws<InvalidDataException>(() => new ProductService(null));
    }

    [Fact]
    public void ProductService_WithNullProductRepository_ThrowsExceptionWithMessage()
    {
        var exception = Assert.Throws<InvalidDataException>(() => new ProductService(null));
        Assert.Equal("Null repository passed to the product service.", exception.Message);
    }

    [Fact]
    public void GetProducts_CallsProductRepositoriesFindAll_ExactlyOnce()
    {
        _service.GetProducts();
        _mock.Verify(r => r.FindAll(), Times.Once);
    }

    [Fact]
    public void GetProducts_NoFilter_ReturnsListOfAllProducts()
    {
        _mock.Setup(r => r.FindAll())
            .Returns(_expected);

        var actualList = _service.GetProducts();

        Assert.Equal(_expected, actualList);
    }
}