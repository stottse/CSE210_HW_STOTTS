
public class Activity{

    protected string  __activityName;
    protected string  __description;
    protected int     __duration;
    public Activity(string activityName, string description) {
        __activityName = activityName;
        __description = description;
    }

    public void DisplayOpeningScreen(){
        //This is where the intro part will display to the user
        Console.WriteLine($"Welcome to the {__activityName} Activity!\n"); // welcome
        
        Console.WriteLine($"_description\n"); // description of activity
        
        // Prompt the user for how long they'd like the activity to go for
        Console.WriteLine("How long would you like for this session to last (seconds)? ");
        __duration = Int32.Parse(Console.ReadLine()); // get input in seconds
    }

    public void CountDown(int seconds) {
        for(; seconds > 0; seconds--)
        {
            Console.Write($"{seconds}"); // display seconds
            Thread.Sleep(1000); // wait for a sec
            Console.Write("\b \b"); // Erase the + character
        }
    }
}

