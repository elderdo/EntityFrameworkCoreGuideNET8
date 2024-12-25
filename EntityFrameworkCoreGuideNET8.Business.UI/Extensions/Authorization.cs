// Example: Creating a Authorization.cs class the file is kept in Extensions Folder in Project EntityFrameworkCoreGuideNET8.Business.UI
namespace EntityFrameworkCoreGuideNET8.Business.UI.Extensions;
/// <summary>
/// Provides extension methods for adding authorization policies.
/// </summary>
public static class Authorization
{
    /// <summary>
    /// Adds an authorization policy that requires the user to have the "Admin" role.
    /// </summary>
    /// <param name="services">The service collection to add the policy to.</param>
    public static void AddAdminAuthorization(this IServiceCollection services)
    {
        services.AddAuthorization(options =>
        {
            options.AddPolicy("AdminOnly", policy =>
            {
                policy.RequireRole("Admin");
            });
        });
    }
}
