using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Please enter your grade:");
        string grade = Console.ReadLine();
        int newGrade = int.Parse(grade);
        string letter = "";
        if (newGrade >= 90)
        {
            letter = "A";
            //Console.WriteLine("You got an A");
        }
        else if (newGrade >= 80)
        {
            letter = "B";
            //Console.WriteLine("You got a B");
        }
        else if (newGrade >= 70)
        {
            letter = "C";
            //Console.WriteLine("You got a C");
        }
        else if (newGrade >= 60)
        {
            letter = "D";
            //Console.WriteLine("You got a D");
        }
        else
        {
            letter = "F";
            //Console.WriteLine("You got a F");
        }
        Console.WriteLine($"You got a {letter}");

        if (newGrade >= 70)
        {
            Console.WriteLine("You Passed");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass. Try again.");
        }

    }
}