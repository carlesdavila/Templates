using ApplicationFramework.Application.Exceptions;
using MediatR;
using ServiceTemplate._1.Application.Interfaces;
using ServiceTemplate._1.Domain.Entities;

namespace ServiceTemplate._1.Application.Users.Queries.GetUserById;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
{
    private readonly IServiceTemplate__1DbContext _dbContext;

    public GetUserByIdQueryHandler(IServiceTemplate__1DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users.FindAsync(request.Id);
        return user ?? throw new NotFoundException(nameof(User), request.Id);

    }
}