
namespace EntityFrameworkCoreGuideNET8.Infrastructure.Domain.Interfaces;

/// <summary>
/// Interface for user repository operations.
/// </summary>
public interface IUserRepository : IService
{
    /// <summary>
    /// Gets a list of user DTOs asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of UserDto.</returns>
    Task<List<UserDto>> GetUserDtosAsync();

    /// <summary>
    /// Gets a list of all active users asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of active User entities.</returns>
    Task<List<User>> GetAllActiveUsersAsync();

    /// <summary>
    /// Loads users with their associated orders asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of User entities with their orders.</returns>
    Task<List<User>> LoadUsersWithOrdersAsync();

    /// <summary>
    /// Saves a user entity asynchronously.
    /// </summary>
    /// <param name="user">The user entity to save.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task SaveAsync(User user);
}
