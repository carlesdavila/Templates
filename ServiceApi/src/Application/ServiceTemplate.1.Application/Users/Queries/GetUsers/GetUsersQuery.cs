using MediatR;
using ServiceTemplate._1.Domain.Entities;

namespace ServiceTemplate._1.Application.Users.Queries.GetUsers;
public class GetUsersQuery : IRequest<List<User>>
{

}