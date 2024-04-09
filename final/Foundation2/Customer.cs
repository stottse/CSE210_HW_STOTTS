using System.ComponentModel;

public class Customer
{

    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool InUsa{
       get{ return _address.checkStateside(); }
    }
}