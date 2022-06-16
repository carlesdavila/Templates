using MediatR;
using ServiceTemplate._1.Application.Interfaces;
using ServiceTemplate._1.Domain.Entities;
using ServiceTemplate._1.Domain.Events;
using ServiceTemplate._1.Domain.ValueObjects;

namespace ServiceTemplate._1.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IServiceTemplate__1DbContext _dbContext;
    private readonly IMediator _mediator;


    public CreateUserCommandHandler(IServiceTemplate__1DbContext dbContext, IMediator mediator)
    {
        _dbContext = dbContext;
        _mediator = mediator;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var newAddress = new Address(request.Address.Street, request.Address.City, request.Address.State, request.Address.Country, request.Address.ZipCode);
        var newUser = new User(request.Name!, request.Email!, newAddress);

        _dbContext.Users.Add(newUser);

        _ = await _dbContext.SaveChangesAsync(cancellationToken);
        
         await _mediator.Publish(new UserCreatedEvent(newUser), cancellationToken);

        return newUser.Id;
    }
}