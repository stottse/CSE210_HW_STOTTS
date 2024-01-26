using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._JobTitle = "Engineer";
        Job1._Company = "Apple";
        Job1._StartYear = 2010;
        Job1._EndYear = 2020;
        // used this to test if it would print --> Job1.ShowJob();

        Job Job2 = new Job();
        Job2._JobTitle = "Senior Engineer";
        Job2._Company = "Microsoft";
        Job2._StartYear = 2020;
        Job2._EndYear = 20224;

        // Used this to test my code --> Job1.Display();
        // Used this to test my code --> Job2.Display();

        Resume Resume1 = new Resume();
        Resume1._Name = "Ethan Stotts";
        Resume1._jobs.Add(Job1);
        Resume1._jobs.Add(Job2);
        Resume1.Display();







    }
}