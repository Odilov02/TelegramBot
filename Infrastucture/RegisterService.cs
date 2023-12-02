
namespace Infrastructure;

public static class RegisterService
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("Default"));
            options.UseLazyLoadingProxies();
        });

        services.AddScoped<IApplicatonDbcontext, ApplicationDbContext>();
        services.AddScoped<IBasketService, BasketService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IFoodService, FoodService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IUserService, UserService>();
        return services;

    }
}
