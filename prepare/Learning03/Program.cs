using System;

class Program
{
    static void Main(string[] args)
    {
        //This first instance will get the default values,hence no parameters
        Fraction first = new Fraction();
        Console.WriteLine (first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        //This second instance will get values with one parameter of value 5
        Fraction second = new Fraction(5);
        Console.WriteLine (second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        //This third instance will get values with two parameters with values 3 and 4
        Fraction third = new Fraction(3,4);
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        //This fourth instance will get values with parameters 1 and 3
        Fraction fourth = new Fraction(1,3);
        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());
        


    }
}