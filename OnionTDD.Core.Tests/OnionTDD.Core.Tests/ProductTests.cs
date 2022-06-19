using OnionTDD.Core.Models;

namespace OnionTDD.Core.Tests;

public class ProductTests
{
    private Product _product = new Product();
    
    [Fact]
    public void Product_CanBeInitialized()
    {
        Assert.NotNull(_product);
    }

    [Fact]
    public void Product_SetID_StoresID_int()
    {
        _product.ID = 1;
        
        Assert.Equal(1, _product.ID);
        Assert.IsType<int>(_product.ID);
    }

    [Fact]
    public void Product_SetName_StoresName_String()
    {
        _product.Name = "Product";
        
        Assert.Equal("Product", _product.Name);
        Assert.IsType<string>(_product.Name);
    }
}