using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mosiah", 2, 22);
        string text = "And behold, all that he requires of you is to keep his commandments; and he has promised you that if ye would keep his commandments ye should prosper in the land; and he never doth vary from that which he hath said; therefore, if ye do keep his commandments he doth bless you and prosper you.";



        Scripture scripture = new Scripture(reference, text);



        Console.WriteLine("Welcome to Scripture Mastery");

        //This is where tge user can select to either quit or have words hiddend
        bool done = false;
        while (done == false)
        {
            scripture.ScriptureDisplay(); // display the scripture
            Console.WriteLine("\n");

            Console.WriteLine("Press the enter key to hide a word in the scripture or type quit to exit the program.");
            string input = Console.ReadLine();
            if(input == "quit"){
                done = true;
            }
            else{
                scripture.HideRandomWord();
                Console.Clear();
            }
        }

        


    }
}