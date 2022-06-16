using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceTemplate._1.Application.Interfaces;
using ServiceTemplate._1.Domain.Events;

namespace ServiceTemplate._1.Application.Users.Commands.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IServiceTemplate__1DbContext _dbContext;
    private readonly IMediator _mediator;

    public DeleteUserCommandHandler(IServiceTemplate__1DbContext dbContext, IMediator mediator)
    {
        _dbContext = dbContext;
        _mediator = mediator;
    }

    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var userToRemove = await _dbContext.Users.FindAsync(request.Id);

        _dbContext.Users.Remove(userToRemove!);

        await _dbContext.SaveChangesAsync(cancellationToken);
        
        await _mediator.Publish(new UserDeletedEvent(userToRemove!), cancellationToken);

        return Unit.Value;
    }
}