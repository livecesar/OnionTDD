using Moq;
using OnionTDD.Core.Models;
using OnionTDD.Core.Services;

namespace OnionTDD.Core.Tests;

public class IProductServiceTests
{
    [Fact]
    public void IProductService_IsAvaliable()
    {
        IProductService service = new Mock<IProductService>().Object;
        Assert.NotNull(service);
    }

    [Fact]
    public void GetProducts_WithNoParams_ReturnListOfAllProducts()
    {
        // Arrange
        var expected = new List<Product>();
        var mock = new Mock<IProductService>();
        mock.Setup(s => s.GetProducts())
            .Returns(expected);
        var service = mock.Object;

        // Act
        var actualProductList = service.GetProducts();
        
        // Assert
        Assert.Equal(expected, actualProductList);
    }
}