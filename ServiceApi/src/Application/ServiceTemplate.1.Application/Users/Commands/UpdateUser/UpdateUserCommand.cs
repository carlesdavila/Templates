using MediatR;

namespace ServiceTemplate._1.Application.Users.Commands.UpdateUser;

public class UpdateUserCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    
    public string? Email { get; set; }

}