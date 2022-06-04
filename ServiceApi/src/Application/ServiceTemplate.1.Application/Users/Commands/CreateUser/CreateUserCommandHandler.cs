using MediatR;
using ServiceTemplate._1.Application.Interfaces;
using ServiceTemplate._1.Domain.Entities;
using ServiceTemplate._1.Domain.ValueObjects;

namespace ServiceTemplate._1.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IServiceTemplate__1DbContext _dbContext;

    public CreateUserCommandHandler(IServiceTemplate__1DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var newAddress = new Address(request.Address.Street, request.Address.City, request.Address.State, request.Address.Country, request.Address.ZipCode);
        var newUser = new User(request.Name!, request.Email!, newAddress);

        _dbContext.Users.Add(newUser);

        _ = await _dbContext.SaveChangesAsync(cancellationToken);

        return newUser.Id;
    }
}