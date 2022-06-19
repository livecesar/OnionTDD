using EntityFrameworkCore.Testing.Moq;
using Microsoft.EntityFrameworkCore;

namespace OnionTDD.DataAccess.Tests;

public class MainDbContextTests
{
    [Fact]
    public void DbContext_WithDbContextOptions_IsAvailable()
    {
        var mockedDbContext = Create.MockedDbContextFor<MainDbContext>();
        Assert.NotNull(mockedDbContext);
    }
    
    [Fact]
    public void DbContext_DbSets_MustHaveDbSetWithTypeProduct()
    {
        
    }
}

public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> contextOptions) : base(contextOptions)
    {
        
    }
}