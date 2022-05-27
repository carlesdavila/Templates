using NUnit.Framework;
using ServiceTemplate._1.Application.Users.Queries.GetUsers;

namespace ServiceTemplate._1.Application.IntegrationTests.Users.Queries.GetUsers;

public class GetUsersTests
{
    [Test]
    public async Task ShouldGetAllUsers()
    {
        //Arrange
        var getUsersQuery = new GetUsersQuery();

        //Act

        //Assert

    }
}