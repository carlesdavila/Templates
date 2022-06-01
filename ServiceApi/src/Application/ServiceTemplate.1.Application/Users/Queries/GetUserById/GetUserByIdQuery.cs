using MediatR;

namespace ServiceTemplate._1.Application.Users.Queries.GetUserById;

public class GetUserByIdQuery : IRequest<UserModel>
{
    public Guid Id { get; set; }
}