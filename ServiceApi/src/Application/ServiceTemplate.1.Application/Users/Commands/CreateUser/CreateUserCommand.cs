using MediatR;

namespace ServiceTemplate._1.Application.Users.Commands.CreateUser;

public class CreateUserCommand : IRequest<Guid>
{
    public string? Name { get; set; }
    public string? Email { get; set; }
}