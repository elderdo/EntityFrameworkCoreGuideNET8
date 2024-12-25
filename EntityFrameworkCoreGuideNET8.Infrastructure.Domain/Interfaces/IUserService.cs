
namespace EntityFrameworkCoreGuideNET8.Infrastructure.Domain.Interfaces;

/// <summary>
/// Provides methods for user-related operations.
/// </summary>
public interface IUserService : IService
{
    /// <summary>
    /// Retrieves all active users asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of active users.</returns>
    Task<List<User>> GetAllActiveUsersAsync();
}
