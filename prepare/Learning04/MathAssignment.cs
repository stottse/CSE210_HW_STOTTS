using System;
class MathAssignment : Assignment
{
    private string _textbookSection;

    public string TextbookSection{
        get {return _textbookSection;}
        set {_textbookSection = value;}
    }

    private string _problems;

    public string Problems{
        get {return _problems;}
        set {_problems = value;}
    }
    public MathAssignment(string name, string topic, string problems, string textbooksection) 
        : base (name, topic) 
    {
        _problems = problems;
        _textbookSection = textbooksection;

    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"Section {_textbookSection} - Problems {_problems}");

    }

}