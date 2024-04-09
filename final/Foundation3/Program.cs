using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Vancouver", "BC", "Canada");
        Address address2 = new Address("456 University Dr", "Rexburg", "ID", "USA");
        Address address3 = new Address("789 Outskirts Dr", "Middleonowhere", "TX", "USA");

        // Create events
        Lecture lecture = new Lecture("Programming With Classes", "Learn about inheritance", "2024-04-10", "10:00 AM", address1, "Lecture", "Brother Smith", "50");
        Reception reception = new Reception("Programming Lab", "Lab to learn more about programming", "2024-04-12", "6:00 PM", address2, "Reception", "programming@byui.edu");
        Outdoor outdoorGathering = new Outdoor("Programming in Nature", "Escape the indoors and program outside for the day", "2024-04-15", "12:00 PM", address3, "Outdoor Event", "75°F and partly cloudy");

        
        Console.WriteLine("Events Comming up!");
        Console.WriteLine("--------------------");

        // The following is for a Lecture:
        
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        // The following is for a Reception:
        
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        // The following is for an Outdoor Event:
        
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
    
