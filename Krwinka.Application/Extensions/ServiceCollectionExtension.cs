namespace Krwinka.Application.Extensions;

using Krwinka.Application.LabTests;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ILabTestsService, LabTestsService>();
    }
}
