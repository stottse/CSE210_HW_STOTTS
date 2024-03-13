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
        Console.WriteLine("Enter selection here:");
        decision = int.Parse(Console.ReadLine());

        Console.Clear();
        if (decision == 1){
            //This will go to the breathing activity class
            BreathingActivity breathingObject = new BreathingActivity("Breathing", "In this activity we will work on timed breathing to help you relax."); // get the toolbox
            Console.WriteLine();
            breathingObject.DisplayOpeningScreen();
            breathingObject.Take_Breaths();
    
            Console.WriteLine();
        }
       
        else if (decision == 2){
            //This will go to the reflection activity class
            ReflectionActivity reflectionObject = new ReflectionActivity("Refecting", "In this activity we will reflect on your successes and strengths.");
            Console.WriteLine();
            reflectionObject.CountDown(10);
            Console.WriteLine();
        }

        else if (decision == 3){
            //This will go to the listing activity
            ListingActivity listingObject = new ListingActivity("Listing", "In this activity we you will list out your strengths in a certain area");
            Console.WriteLine();
            listingObject.CountDown(10);
            Console.WriteLine();
        }

        else{
            Console.WriteLine("Goodbye!");
        }


            }
        }
    
