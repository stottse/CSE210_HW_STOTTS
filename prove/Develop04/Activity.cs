
public class Activity{

    protected string  _activityName;
    protected string  _description;
    protected int     _duration;
    public Activity(string activityName, string description) {
        _activityName = activityName;
        _description = description;
        

    }

    public void DisplayOpeningScreen()
    {
        //This is where the intro part will display to the user
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n"); // welcome
        
        Console.WriteLine($"{_description}\n"); // description of activity
        
        // Prompt the user for how long they'd like the activity to go for
        Console.WriteLine("How long would you like for this session to last (seconds)? ");
        _duration = Int32.Parse(Console.ReadLine()); // get input in seconds

        Console.WriteLine();
        Console.WriteLine($"Starting {_activityName} Activity...");

    }

    public void CountDown(int seconds) {
        for(; seconds > 0; seconds--)
        {
            Console.Write($"{seconds}"); // display seconds
            Thread.Sleep(1000); // wait for a sec
            Console.Write("\b \b"); // Erase the + character
        }
    }
    public void EndDisplay(){
        Console.WriteLine();
        Console.WriteLine($"Good job! You completed the {_activityName} activity!");
        Console.WriteLine($"You completed another {_duration} seconds of the {_activityName} activity!");
    }
}

