namespace EntityFrameworkCoreGuideNET8.Business.UI.Extensions;

/// <summary>
/// Extension methods for adding custom services to the IServiceCollection.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds custom services to the specified IServiceCollection.
    /// </summary>
    /// <param name="services">The IServiceCollection to add services to.</param>
    /// <param name="configuration">The IConfiguration to use for configuring services.</param>
    public static void AddCustomServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Register the DbContext
        services.AddDbContext<DemoDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Register IUserRepository and its implementation
        services.AddScoped<IUserRepository, UserRepository>();

        // Register IUserService and its implementation
        services.AddScoped<IUserService, UserService>();

        // Example: Configuring authentication and authorization in ASP.NET Core
        services.AddJwtAuthentication(configuration);
        services.AddAdminAuthorization();
    }
}
