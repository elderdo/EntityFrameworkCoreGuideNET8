// DTOs.cs file  in Project EntityFrameworkCoreGuideNET8.Infrastructure.Data
namespace EntityFrameworkCoreGuideNET8.Infrastructure.Domain.DTOs;
/// <summary>
/// Data Transfer Object for User entity.
/// </summary>
/// <param name="Id">Unique identifier for the user.</param>
/// <param name="FirstName">First name of the user.</param>
/// <param name="LastName">Last name of the user.</param>
/// <param name="Email">Email address of the user.</param>
/// <param name="Phone">Phone number of the user.</param>
/// <param name="IsActive">Indicates whether the user is active.</param>
public record UserDto(Guid Id, string FirstName, string LastName, string Email, string Phone, bool IsActive);


/// <summary>
/// Data Transfer Object for Order entity.
/// </summary>
/// <param name="Id">Unique identifier for the order.</param>
/// <param name="UserId">Unique identifier for the user who placed the order.</param>
/// <param name="ProductName">Name of the product ordered.</param>
/// <param name="Price">Price of the product ordered.</param>
/// <param name="OrderDate">Date when the order was placed.</param>
public record OrderDto(Guid Id, Guid UserId, string ProductName, decimal Price, DateTime OrderDate);
