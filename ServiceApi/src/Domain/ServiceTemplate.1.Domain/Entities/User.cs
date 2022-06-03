using ServiceTemplate._1.Domain.ValueObjects;

namespace ServiceTemplate._1.Domain.Entities;

public class User : Entity
{
    public string Name { get; private set; }

    public Address Address { get; private set; }

    //Constructor needed because EF6 cannot bind parameter constructor to ValueObject 
    private User() { }

    public User(string name, Address address)
    {
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(address);

        Name = name;
        Address = address;
    }

    public void Update(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
}
