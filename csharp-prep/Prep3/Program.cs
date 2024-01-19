using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("I'm thinking of a magic number between 1 and 100.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = 0;




        while (number != guess){
            Console.WriteLine("Please guess the magic number");
            string newGuess = Console.ReadLine();
            guess = int.Parse(newGuess);
            if (number > guess){
                Console.WriteLine("Your guess is too low");
            }
            else if (number < guess){
                Console.WriteLine("Your guess is too high");
            }
            else{
                Console.WriteLine("You guessed correctly!");
            }
            
        }
        

    }
}