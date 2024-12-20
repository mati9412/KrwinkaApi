﻿namespace Krwinka.Infrastructure.Repositories;

using Krwinka.Domain.Entities;
using Krwinka.Domain.Repositories;
using Krwinka.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

internal class LabTestsRepository(KrwinkaDbContext dbContext) : ILabTestsRepository
{
    public async Task<IEnumerable<LabTest>> GetAllLabTestsAsync() => await dbContext.Labtests.ToListAsync();
    public async Task<LabTest?> GetLabTestAsync(int id)
    {
        return await dbContext.Labtests.FirstOrDefaultAsync(l => l.Id == id);
    }
}
