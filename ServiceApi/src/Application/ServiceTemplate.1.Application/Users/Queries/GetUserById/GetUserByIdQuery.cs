using MediatR;
using ServiceTemplate._1.Domain.Entities;

namespace ServiceTemplate._1.Application.Users.Queries.GetUserById;

public class GetUserByIdQuery : IRequest<User>
{
    public Guid Id { get; set; }
}