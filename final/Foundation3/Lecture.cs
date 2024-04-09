public class Lecture : Event
{
    private string _speaker;

    //Typically the capacity would be an int, but I made it a string for easier concatenation:
    private string _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string eventType, string speaker, string capacity): base(title, description, date,time, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;

    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails()+ $"Speaker: {_speaker}\nCapacity: {_capacity}";
    }


}