using MediatR;

namespace ServiceTemplate._1.Application.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
{

    public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}