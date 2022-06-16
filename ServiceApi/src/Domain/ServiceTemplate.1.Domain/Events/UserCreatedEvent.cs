using MediatR;

namespace ServiceTemplate._1.Domain.Events;

public class UserCreatedEvent : INotification
{
    public UserCreatedEvent(User user)
    {
        this.User = user;
    }

    public User User { get; }

}