using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;


class Program
{
    
    static void Main(string[] args)
    {   //The following is setting a list of prompts and then giving a random prompt:
        List <string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person you interacted with today?");
        prompts.Add("What was the best part of your day?");
        prompts.Add("How did I see the Lord's hand in my life today?");
        prompts.Add("What is the strongest emotion I felt today?");
        prompts.Add("Did I help someone in need today?");
        prompts.Add("What could i have done differently today?");
        prompts.Add("Did I feel the spirit in my life today?");
        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count);
        string randomPrompt = prompts[randomIndex];

        //Entry userentry = new Entry(randomPrompt);
        


        //The Following is the loop for the user to select what happens:
        Console.WriteLine("Please select from the following:");
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        string Option_Selected = Console.ReadLine();

        Journal newjournal = new Journal();

        while (Option_Selected!= "0"){

            switch (Option_Selected)
            {
                case "0":
                    break;

                case "1":
                    Console.WriteLine(randomPrompt);
                    Entry userentry = new Entry(randomPrompt);
                    userentry.EnterEntry();
                    newjournal.Entries.Add(userentry);
                    break;

                case "2":
                    
                    newjournal.DisplayEntries();
                    break;
                case "3":
                    break;
                case "4":
                    break;

                default:
                    Console.WriteLine("Invalid, try again");
                    break;
            }

        Console.WriteLine("Please select from the following:");
        Console.WriteLine("0. Exit");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Option_Selected = Console.ReadLine();

                
                
        
        }


    


    
    }
}