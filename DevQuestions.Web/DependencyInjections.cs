using DevQuestions.Application;

namespace DevQuestions.Web;

public static class DependencyInjections
{
    public static IServiceCollection  (this IServiceCollection services)
    {
        services.AddApplication();
        services.AddWebDependencies();
        return services;
    }

    private static IServiceCollection AddWebDependencies(this IServiceCollection service)
    {
        // Add services to the container.
        service.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        service.AddSwaggerGen();

        return service;
    }
}
