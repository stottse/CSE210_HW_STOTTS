public class Address{

    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //Checks to see if shipping is within the USA
    public bool IsInUSA()
    {
        return _country == "USA";  

    }

    //The following gets the address for the order:
    public string GetAddress(){
        return ($"{_street}, {_city}, {_state}, {_country}");
    }
}