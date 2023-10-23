using Full.Server.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Full.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly ITestRepository _testRepository;

    public TestController(ITestRepository testRepository) => _testRepository = testRepository;

    [HttpGet("one")]
    public async Task<IActionResult> GetTest(int id) => Ok(await _testRepository.GetTestListAsync(id));

}
