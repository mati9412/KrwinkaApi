namespace Krwinka.Application.LabTests;

using Krwinka.Domain.Entities;
using Krwinka.Domain.Repositories;

internal class LabTestsService(ILabTestsRepository labTestsRepository) : ILabTestsService
{
    public async Task<IEnumerable<LabTest>> GetAll() => await labTestsRepository.GetAllLabTestsAsync();
    public async Task<LabTest?> GetLabTest(int id) => await labTestsRepository.GetLabTestAsync(id);

}
