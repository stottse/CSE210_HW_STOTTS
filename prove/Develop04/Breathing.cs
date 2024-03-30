public class BreathingActivity : Activity 
{
    public BreathingActivity(string activityName, string description) : base(activityName, description) 
    {
        _activityName = activityName;
        _description = description;
        
        
    }
    public void Take_Breaths()
    {
        CountDown(5);

        for (int i = 0; i < (_duration/3); i++)
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
        
    }
        
    }

