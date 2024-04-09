using System.ComponentModel;

public class Customer
{

    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Checks to see if shipping is within USA
    public bool IsInUsa()
    {
       return _address.IsInUSA();
    }

    //Depending on if shipping is in USA or not it determines the shipping cost:
    public double GetShippingCost()
    {
        return IsInUsa() ? 5 : 35;

    }

    //THE FOLLOWING I GOT HELP ON FROM ONLINE:
    public override string ToString()
    {
        return $"Customer Name: {_name}\nAddress: {_address.GetAddress()}";
    }
}