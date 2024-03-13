using System;

class Program
{
    static void Main(string[] args)
    {
        //The first one to try and get name and topic
        Assignment assign = new Assignment ("Ethan ", "Calculus");
        assign.GetSummary();

        //This one should give name, topic, section, and problems
        MathAssignment math = new MathAssignment ("Ethan" , "Calculus", "1-5", "3.6");
        math.GetSummary();
        math.GetHomeworkList();

        //This one will give name, topic, and writing title
        WritingAssignment writing = new WritingAssignment ("Anna", "Writing", "How to write code");
        writing.GetSummary();
        writing.GetWritingInformation();

    }
}