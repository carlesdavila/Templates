using ApplicationFramework.Presentation.Web;
using Microsoft.AspNetCore.Mvc;
using ServiceTemplate._1.Application.Users.Commands.CreateUser;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceTemplate._1.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ApiControllerBase
{
    public record NewUser(string Name);
    public record UpdateUser(string Name);

    // GET: api/<UserController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<UserController>
    [HttpPost]
    public async Task<CreatedResult> Post([FromBody] NewUser newUser)
    {
        var command = new CreateUserCommand(){Name = newUser.Name};
        
        return Created(string.Empty, await Mediator.Send(command));
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] UpdateUser value)
    {
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

