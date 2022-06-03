using MediatR;
using Microsoft.EntityFrameworkCore;
using ServiceTemplate._1.Application.Interfaces;
using ServiceTemplate._1.Domain.Entities;

namespace ServiceTemplate._1.Application.Users.Queries.GetUsers;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<User>>
{
    private readonly IServiceTemplate__1DbContext _dbContext;

    public GetUsersQueryHandler(IServiceTemplate__1DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Users.ToListAsync(cancellationToken);
    }
}