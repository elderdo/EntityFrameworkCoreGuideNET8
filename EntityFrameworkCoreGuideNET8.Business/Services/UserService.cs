using EntityFrameworkCoreGuideNET8.Infrastructure.Domain.Interfaces;
using EntityFrameworkCoreGuideNET8.Infrastructure.Domain.Models;


namespace EntityFrameworkCoreGuideNET8.Business.Services;

/// <summary>
/// Service for managing user-related operations.
/// </summary>
public class UserService : IUserService
{
    private bool _disposed = false;
    private readonly IUserRepository? _userRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserService"/> class.
    /// </summary>
    /// <param name="userRepository">The user repository.</param>
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    /// <summary>
    /// Gets all active users asynchronously.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the list of active users.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the user repository is not initialized.</exception>
    public Task<List<User>> GetAllActiveUsersAsync() =>
        _userRepository != null ? _userRepository.GetAllActiveUsersAsync() :
        throw new InvalidOperationException("User repository is not initialized.");

    /// <summary>
    /// Releases the unmanaged resources used by the <see cref="UserService"/> and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing && _userRepository != null)
            _userRepository.Dispose();

        _disposed = true;
    }

    /// <summary>
    /// Releases all resources used by the <see cref="UserService"/>.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}

