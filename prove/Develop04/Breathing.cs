public class BreathingActivity : Activity 
{
    public BreathingActivity(string activityName, string description) : base(activityName, description) {
        __activityName = activityName;
        __description = description;
        
    }
    public void Take_Breaths(){

        // int __duration = base.__duration;
        Console.WriteLine();

        // Start breathing activity
    Console.WriteLine("Starting breathing activity...");

    for (int i = 0; i < (__duration/3); i++)
    {
        // Alternate between "Breathe in..." and "Breathe out..."
        if (i % 2 == 0)
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write("Breathe in...");
        }
        else
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write("Breathe out...");
        }

        // Pause for several seconds and show a countdown
        CountDown(3); // Pause for 3 seconds before the next message
    }

    // Display the standard finishing message
    Console.WriteLine();
    Console.WriteLine("Breathing activity completed.");
    CountDown(5);
    EndDisplay();
}
        

    }

