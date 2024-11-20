namespace Krwinka.Infrastructure.Extensions;

using Krwinka.Domain.Repositories;
using Krwinka.Infrastructure.Persistence;
using Krwinka.Infrastructure.Repositories;
using Krwinka.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<KrwinkaDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("KrwinkaConnectionString")));
        services.AddScoped<ILabTestSeeder, LabTestSeeder>();
        services.AddScoped<ILabTestsRepository, LabTestsRepository>();
    }
}
