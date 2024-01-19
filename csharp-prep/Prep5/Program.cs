using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string UserName = PromptUserName();
        int Usernumber = PromptUserNumber();
        int SquaredNumber = SqaureNumber(Usernumber);
        DisplayResult(SquaredNumber,UserName);

    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite integer number");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }
    static int SqaureNumber(int square){
        int squared = square * square;
        return squared;
    }
    static void DisplayResult(int squared, string name){
        Console.WriteLine($"{name}, your number squared is {squared}");

    }
}