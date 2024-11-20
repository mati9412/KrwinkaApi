namespace KrwinkaApi.Controllers;

using Krwinka.Application.LabTests;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/lab-tests")]
public class LabTestsController(ILabTestsService labTestsService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetLabTests()
    {
        var tests = await labTestsService.GetAll();
        return Ok(tests);
    }
}
