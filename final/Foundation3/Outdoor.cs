public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, Address address, string eventDetails, string eventType, string weather): base(title, description, date,time, address, eventDetails, eventType)
    {
        _weather = weather;

    }

}