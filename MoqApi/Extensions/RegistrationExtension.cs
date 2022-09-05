using MoqApi.Services;

namespace MoqApi.Extensions;

public static class RegistrationExtensions
{
    public static void Register(this IServiceCollection services, IConfiguration configuration)
    {
        RegisterServices(services, configuration);
    }

    // Creating a Registration Extension method to separate out registration from Endpoint logic
    private static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IRecipeService, RecipeService>();
    }
}