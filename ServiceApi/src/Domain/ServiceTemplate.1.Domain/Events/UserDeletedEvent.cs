using MediatR;

namespace ServiceTemplate._1.Domain.Events;

public class UserDeletedEvent : INotification
{
    public UserDeletedEvent(User user)
    {
        this.User = user;
    }

    public User User { get; }
}