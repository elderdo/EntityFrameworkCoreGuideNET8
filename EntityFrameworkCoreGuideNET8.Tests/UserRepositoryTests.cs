//UserRepositoryTests.cs class the file is kept in   Project EntityFrameworkCoreGuideNET8.Tests

namespace EntityFrameworkCoreGuideNET8.Tests;

/// <summary>
/// Contains unit tests for the UserRepository class.
/// </summary>
public class UserRepositoryTests
{
    // Example: Writing unit tests for EF Core repositories

    /// <summary>
    /// Tests that GetAllActiveUsersAsync method returns all active users.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    [Fact]
    public async Task GetUsers_ReturnsAllUsers()
    {
        // Arrange
        var dbContext = DbContextMocker.GetDemoDbContext(nameof(GetUsers_ReturnsAllUsers));
        var repository = new UserRepository(dbContext);

        // Act
        var users = await repository.GetAllActiveUsersAsync();

        // Assert
        Assert.Equal(3, users.Count);
    }
}
