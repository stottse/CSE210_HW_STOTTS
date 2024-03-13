using System.Reflection.Metadata.Ecma335;

class Assignment{
    protected string _studentName;
    
    private string _topic;

    public string Name
    {
        get {return _studentName;}
        set {_studentName = value;}
    }

    public string Topic
    {
        get {return _topic;}
        set {_topic = value;}
    }

    public Assignment (string name, string topic){
        _studentName = name;
        _topic = topic;
    }

    public void GetSummary(){
        Console.Write(_studentName);
        Console.WriteLine($" - {_topic}");

    }
    
    }