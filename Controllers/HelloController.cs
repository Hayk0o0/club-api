using Microsoft.AspNetCore.Mvc;

namespace ClubApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Привет, клуб!";   
    }

    [HttpGet("{name}")]
    public string Get(string name)
    {
        return $"Привет, {name}!";
    }
}