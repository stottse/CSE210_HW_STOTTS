using System;
using System.Runtime.InteropServices;

class Program
{

    /*
    //I should put this into an activity class:
    static int Greeting (string activity){
        if (activity == "Breathing"){
            Console.WriteLine("Welcome to the Breathing activity!");
            Console.WriteLine("In this activity we will work on timed breathing.");
        }

        else if (activity == "Reflection"){
        Console.WriteLine("Welcome to the Reflection acticity");
        Console.WriteLine("In this activity we will  reflect on your successes and strengths.");
        }

        else if (activity == "Listing"){
        Console.WriteLine("Welcome to the Listing acticity");
        Console.WriteLine("In this activity we you will list out your strengths in a certain area");
        }

        Console.WriteLine("Please enter the amount of time in seconds that you would like to do the acticity for.");
        int time = int.Parse(Console.ReadLine());

        return time;

        */





    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        //The following part is going to let the user select which activity they want to do:

       Console.WriteLine("Please enter the number for which activity you would like to do.");
       Console.WriteLine("1. Breathing activity");
       Console.WriteLine("2. Reflection activity");
       Console.WriteLine("3. Listing activity");
       Console.WriteLine("4. Quit");
       int decision = 0;
       Console.WriteLine("Enter selection here:");
       decision = int.Parse(Console.ReadLine());

       if (decision == 1){
        //This will go to the breathing activity class
        

       }
       
       else if (decision == 2){
        //This will go to the reflection activity class
        
       }

       else if (decision == 3){
        //This will go to the listing activity
        
       }

       else{
        Console.WriteLine("Goodbye!");
       }
       
       
       
       
       
       
       
       //I dont think I will use this format anymore:

       /* bool done = false;
        while (done == false)
        {
            //Breathing activity selection
            Console.WriteLine("If you would like to do another activity press enter otherwise type quit.");
            string input = Console.ReadLine();
            if(input == "quit"){
                done = true;

            //Reflection activity selection
            Console.WriteLine("If you would like to do another activity press enter otherwise type quit.");
            input = Console.ReadLine();
            if(input == "quit"){
                done = true;

            //Listing Activity Selection
            Console.WriteLine("If you would like to do another activity press enter otherwise type quit.");
            input = Console.ReadLine();

            if(input == "quit"){
                done = true;
                */






            }
        }
    
