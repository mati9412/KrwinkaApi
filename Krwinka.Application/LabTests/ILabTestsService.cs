﻿namespace Krwinka.Application.LabTests;

using Krwinka.Domain.Entities;

public interface ILabTestsService
{
    Task<IEnumerable<LabTest>> GetAll();
}