//DbContextMocker.cs class the file is kept in   Project EntityFrameworkCoreGuideNET8.Tests


namespace EntityFrameworkCoreGuideNET8.Tests;
/// <summary>
/// Provides methods to create and configure an in-memory database context for testing.
/// </summary>
public static class DbContextMocker
{
    /// <summary>
    /// Creates a new instance of <see cref="DemoDbContext"/> with an in-memory database.
    /// </summary>
    /// <param name="dbName">The name of the in-memory database.</param>
    /// <returns>A configured <see cref="DemoDbContext"/> instance.</returns>
    public static DemoDbContext GetDemoDbContext(string dbName)
    {
        var options = new DbContextOptionsBuilder<DemoDbContext>()
            .UseInMemoryDatabase(databaseName: dbName)
            .Options;

        var dbContext = new DemoDbContext(options);

        // Seed your in-memory database with test data if needed

        return dbContext;
    }
}
