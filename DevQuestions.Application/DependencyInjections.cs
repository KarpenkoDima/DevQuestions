using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using DevQuestions.Application.Questions;
namespace DevQuestions.Application;

public static  class DependencyInjections
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblies((IEnumerable<System.Reflection.Assembly>)typeof(DependencyInjections).Assembly);
        services.AddScoped<IQuestionsService, QuestionsService>();

        return services;

    }
}
