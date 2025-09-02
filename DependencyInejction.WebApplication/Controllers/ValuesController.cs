using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.WebApplication.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
                           // primary constructor
public class ValuesController(Builder _builder) : ControllerBase
{
    
    [HttpGet]
    public IActionResult Get()
    {
        _builder.BuildHouse();
        return Ok();
    }
}
