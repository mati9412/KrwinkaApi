namespace KrwinkaApi.Controllers;

using Krwinka.Application.LabTests;
using Microsoft.AspNetCore.Components.Forms;
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

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetLabTest([FromRoute] int id)
    {
        var test = await labTestsService.GetLabTest(id);
        if (test == null) return NotFound();
        return Ok(test);
    }
}
