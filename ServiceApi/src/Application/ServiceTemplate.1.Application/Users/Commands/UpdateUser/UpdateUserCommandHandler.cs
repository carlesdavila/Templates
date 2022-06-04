using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceTemplate._1.Application.Interfaces;

namespace ServiceTemplate._1.Application.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
{
    private readonly IServiceTemplate__1DbContext _dbContext;

    public UpdateUserCommandHandler(IServiceTemplate__1DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var userToUpdate = await _dbContext.Users.FirstAsync(x => x.Id == request.Id, cancellationToken);

        userToUpdate.Update(request.Name!, request.Email!);
        
        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}