namespace OnlineOrdering;

public class Customer
{
    public string Name { get; private set; }
    public Address Address { get; private set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool LivesInUSA() => Address.IsInUSA();

    public string GetShippingAddress() => Address.GetFullAddress();
}
