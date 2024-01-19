using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You will be adding numbers to a list.");
        int selection = 1;
        List<int> numbers = new List<int>();


        while (selection != 0){
                Console.WriteLine("Please enter an integer number to add to the list");
                string number = Console.ReadLine();
                int newNumber = int.Parse(number);
                numbers.Add(newNumber);
            if (selection !=0){
                Console.WriteLine("Enter a 1 to add another number to the list.");
                Console.WriteLine("Enter a 0 to exit");
                string choice =Console.ReadLine();
                selection = int.Parse(choice);
            }
           


        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

         int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}