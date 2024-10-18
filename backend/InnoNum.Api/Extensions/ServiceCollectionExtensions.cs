using Microsoft.Extensions.DependencyInjection;
using InnoNum.Model.Services;

namespace InnoNum.Model.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddPerfectNumbers(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IPerfectNumberService, PerfectNumberService>();
    }
}
