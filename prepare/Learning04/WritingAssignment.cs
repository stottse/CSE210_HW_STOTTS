using System.Reflection;
using System;

class WritingAssignment : Assignment
{
    private string _title;

    public string Title
    {
        get {return _title;}
        set {_title = value;}
    }

    public WritingAssignment(string name, string topic, string title) 
        : base (name, topic)
    {
            _title = title;

    }

    public void GetWritingInformation()
    {
        Console.WriteLine($"{_title}");

    }


}