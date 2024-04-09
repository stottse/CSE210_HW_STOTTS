public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string eventDetails, string eventType, string email): base(title, description, date,time, address, eventDetails, eventType)
    {
        _email = email;
        

    }

}