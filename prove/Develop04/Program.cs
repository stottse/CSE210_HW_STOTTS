using System;
using System.Runtime.InteropServices;

class Program
{


    static void Main(string[] args)
    {
    

        //The following part is going to let the user select which activity they want to do:

        Console.WriteLine("Please enter the number for which activity you would like to do.");
        Console.WriteLine("1. Breathing activity");
        Console.WriteLine("2. Reflection activity");
        Console.WriteLine("3. Listing activity");
        Console.WriteLine("4. Quit");
        int decision = 0;
        Console.Write("Enter selection here:");
        decision = int.Parse(Console.ReadLine());

        Console.Clear();
        if (decision == 1)
        {
            //This will go to the breathing activity class
            BreathingActivity breathingObject = new BreathingActivity("Breathing", "In this activity we will work on timed breathing to help you relax."); // get the toolbox
            Console.WriteLine();
            breathingObject.DisplayOpeningScreen();
            breathingObject.Take_Breaths();
            breathingObject.EndDisplay();
    
            Console.WriteLine();
        }
       
        else if (decision == 2)
        {
            //This will go to the reflection activity class
            ReflectionActivity reflectionObject = new ReflectionActivity("Refecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine();
            reflectionObject.DisplayOpeningScreen();
            reflectionObject.Reflection_Time();
            reflectionObject.EndDisplay();
        }

        else if (decision == 3)
        {
            //This will go to the listing activity
            ListingActivity listingObject = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine();
            listingObject.DisplayOpeningScreen();
            listingObject.Listing_Time();
            listingObject.EndDisplay();

        }

        else{
            Console.WriteLine("Goodbye!");
        }


            }
        }
    
