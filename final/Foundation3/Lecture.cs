public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string eventDetails, string eventType, string speaker, string capacity): base(title, description, date,time, address, eventDetails, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;

    }
    

}