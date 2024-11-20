﻿namespace Krwinka.Domain.Repositories;

using Krwinka.Domain.Entities;

public interface ILabTestsRepository
{
    Task<IEnumerable<LabTest>> GetAllLabTestsAsync();
}