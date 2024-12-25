// Example: Creating a UserRepository class the file is kept in Models Folder in Project EntityFrameworkCoreGuideNET8.Domain
namespace EntityFrameworkCoreGuideNET8.Infrastructure.Domain.Models;
/// <summary>
/// Represents an order placed by a user.
/// </summary>
public record Order
{
    /// <summary>
    /// Gets the unique identifier for the order.
    /// </summary>
    [Key]
    public Guid Id { get; init; }

    /// <summary>
    /// Gets the unique identifier for the user who placed the order.
    /// </summary>
    public Guid UserId { get; init; }

    /// <summary>
    /// Gets the user who placed the order.
    /// </summary>
    [ForeignKey("UserId")]
    public required User User { get; init; }

    /// <summary>
    /// Gets the name of the product ordered.
    /// </summary>
    [Required]
    public string ProductName { get; init; } = string.Empty;

    /// <summary>
    /// Gets the price of the product ordered.
    /// </summary>
    [Required, Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
    public decimal Price { get; init; }

    /// <summary>
    /// Gets the date when the order was placed.
    /// </summary>
    [Required]
    public DateTime OrderDate { get; init; }
}
