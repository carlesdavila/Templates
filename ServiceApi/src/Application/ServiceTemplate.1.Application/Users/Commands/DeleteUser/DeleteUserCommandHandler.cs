using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceTemplate._1.Application.Interfaces;

namespace ServiceTemplate._1.Application.Users.Commands.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Unit>
{
    private readonly IServiceTemplate__1DbContext _dbContext;

    public DeleteUserCommandHandler(IServiceTemplate__1DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var userToRemove = await _dbContext.Users.FirstAsync(x => x.Id == request.Id, cancellationToken);

        _dbContext.Users.Remove(userToRemove);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}