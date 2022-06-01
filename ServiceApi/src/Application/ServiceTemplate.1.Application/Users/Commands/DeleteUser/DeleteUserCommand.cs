using MediatR;

namespace ServiceTemplate._1.Application.Users.Commands.DeleteUser;

public class DeleteUserCommand : IRequest
{
    public Guid Id { get; set; }
}