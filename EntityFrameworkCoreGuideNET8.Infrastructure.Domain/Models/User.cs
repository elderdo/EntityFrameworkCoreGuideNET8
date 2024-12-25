// Example: Creating a User record the file is kept in Models Folder in Project EntityFrameworkCoreGuideNET8.Infrastructure.Data
namespace EntityFrameworkCoreGuideNET8.Infrastructure.Domain.Models;
/// <summary>
/// Represents a user in the system.
/// </summary>
public record User
{
    /// <summary>
    /// Gets the unique identifier for the user.
    /// </summary>
    [Key]
    public Guid Id { get; init; }

    /// <summary>
    /// Gets the list of orders associated with the user.
    /// </summary>
    public List<Order> Orders { get; init; } = new List<Order>();

    /// <summary>
    /// Gets the first name of the user.
    /// </summary>
    [Required]
    public string FirstName { get; init; } = string.Empty;

    /// <summary>
    /// Gets the last name of the user.
    /// </summary>
    [Required]
    public string LastName { get; init; } = string.Empty;

    /// <summary>
    /// Gets the email address of the user.
    /// </summary>
    [Required]
    public string Email { get; init; } = string.Empty;

    /// <summary>
    /// Gets a value indicating whether the email address has been confirmed.
    /// </summary>
    [Required]
    public string EmailConfirmed { get; init; } = string.Empty;

    /// <summary>
    /// Gets the phone number of the user.
    /// </summary>
    [Required]
    public string Phone { get; init; } = string.Empty;

    /// <summary>
    /// Gets a value indicating whether the phone number has been confirmed.
    /// </summary>
    [Required]
    public string PhoneConfirmed { get; init; } = string.Empty;

    /// <summary>
    /// Gets a value indicating whether the user is active.
    /// </summary>
    public bool IsActive { get; init; } = false;

    /// <summary>
    /// Gets or sets the row version for concurrency control.
    /// </summary>
    [Timestamp]
    public byte[]? RowVersion { get; set; }
}
