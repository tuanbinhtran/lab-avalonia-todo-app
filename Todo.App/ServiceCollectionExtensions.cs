using Microsoft.Extensions.DependencyInjection;

namespace Todo.App;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection services)
    {
        services.AddSingleton<DAL.DbConnectionFactory>();

        services.Add
    }
}