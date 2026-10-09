using ClubApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClubApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    private static readonly List<Client> _clients =
    [
        new Client { Id = 1, Name = "Арман", Phone = "077-111-111" },
        new Client { Id = 2, Name = "Лена", Phone = "077-222-222" },
        new Client { Id = 3, Name = "Давид", Phone = "077-333-333" }
    ];

    [HttpGet]
    public List<Client> GetAll()
    {
        return _clients;   
    }

    [HttpGet("{id}")]
    public ActionResult<Client> GetById(int id)
    {
        var client = _clients.FirstOrDefault(c => c.Id == id);

        if (client == null)
        {
            return NotFound();
        }

        return Ok(client);
    }
}