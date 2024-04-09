//This will be the parent class:
public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    //I am going to try and go into the child class and from there load in the info to the parent class
    protected string _eventType;

    public Event(string eventTitle, string description, string date, string time, Address address, string eventType)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;

    }

    public string GetStandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nAddress: {_address.GetAddress()}\n";
    }

    public virtual string GetFullDetails()
    {
        return $"Event Type: {_eventType}\n" + GetStandardDetails();

    }

    public string GetShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date}";

    }

}






