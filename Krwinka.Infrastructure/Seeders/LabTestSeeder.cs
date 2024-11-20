namespace Krwinka.Infrastructure.Seeders;

using Krwinka.Domain.Entities;
using Krwinka.Infrastructure.Persistence;

internal class LabTestSeeder(KrwinkaDbContext dbContext) : ILabTestSeeder
{
    public async Task Seed()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Labtests.Any())
            {
                List<LabTest> tests = new List<LabTest>()
                {
                    new LabTest
                    {
                        Name = "Morfologia",
                        Type = "EDTA",
                        Description = "Test",
                        Price = 10,
                        External = false,
                        Stability = true
                    },
                    new LabTest
                    {
                        Name = "AST",
                        Type = "Surowica",
                        Description = "Test",
                        Price = 15,
                        External = false,
                        Stability = true
                    }
                };
                dbContext.Labtests.AddRange(tests);
                await dbContext.SaveChangesAsync();
            };
        }
    }
}

