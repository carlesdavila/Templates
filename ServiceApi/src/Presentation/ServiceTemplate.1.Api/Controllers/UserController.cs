using ApplicationFramework.Presentation.Web;
using Microsoft.AspNetCore.Mvc;
using ServiceTemplate._1.Application.Users.Commands.CreateUser;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceTemplate._1.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ApiControllerBase
{
    public record NewUser(string Name, string Email);
    public record UpdatedUser(string Name);

    // GET: api/<UserController>
    [HttpGet]
    public IEnumerable<string> GetAll()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public string GetUser(int id)
    {
        return "value";
    }

    // POST api/<UserController>
    [HttpPost]
    public async Task<CreatedResult> CreateUser([FromBody] NewUser newUser)
    {
        var command = new CreateUserCommand(){Name = newUser.Name, Email = newUser.Email};
        
        return Created(string.Empty, await Mediator.Send(command));
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public void UpdateUser(int id, [FromBody] UpdatedUser value)
    {
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void DeleteUser(int id)
    {
    }
}

