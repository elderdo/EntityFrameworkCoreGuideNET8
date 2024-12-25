// Example: Creating a JwtAuthentication.cs class the file is kept in Extensions Folder in Project EntityFrameworkCoreGuideNET8.Business.UI
namespace EntityFrameworkCoreGuideNET8.Business.UI.Extensions;
/// <summary>
/// Provides extension methods for adding JWT authentication to the service collection.
/// </summary>
public static class JwtAuthentication
{
    /// <summary>
    /// Adds JWT authentication to the specified service collection.
    /// </summary>
    /// <param name="services">The service collection to add authentication to.</param>
    /// <param name="configuration">The configuration containing JWT settings.</param>
    public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        // Example: Configuring authentication and authorization in ASP.NET Core
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]))
                };
            });
    }
}
