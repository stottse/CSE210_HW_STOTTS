public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, Address address, string eventType, string weather): base(title, description, date,time, address, eventType)
    {
        _weather = weather;

    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"Weather: {_weather}\n";

    }

}