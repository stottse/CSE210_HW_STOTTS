using System.Diagnostics;

public class ReflectionActivity : Activity
{

    private List<string> questions = new List<string>();
    private List<string> prompts = new List<string>();
    public ReflectionActivity(string activityName, string description) : base(activityName, description) 
    {
        _activityName = activityName;
        _description = description;
        

        //The following are the prompts for the user will reflect on:
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone else.");
        prompts.Add("Think of time whe you did something truly selfless.");

        //The following is setting up the questions for the user to reflect on:
        questions.Add("Why is this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was completed?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
    }
    public void Reflection_Time()
    {
        CountDown(5);

        //Get a random prompt
        Random random = new Random ();
        int randomIndex = random.Next(0,prompts.Count);
        Console.WriteLine(prompts[randomIndex]);
        CountDown(9);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);


        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {       
            Console.WriteLine();
            //Display a random question
            Random random1 = new Random ();
            int randomIndex1 = random.Next(0,questions.Count);
            Console.WriteLine(questions[randomIndex1]);
            

            // Pause for several seconds and show a countdown
            CountDown(8); // Pause for 8 seconds before the next message

        }

        //for (int i = 0; i < (_duration/8); i++)
        //{
           // Console.WriteLine();
            //Display a random question
          //  Random random1 = new Random ();
           // int randomIndex1 = random.Next(0,questions.Count);
          //  Console.WriteLine(questions[randomIndex1]);
            

            // Pause for several seconds and show a countdown
          //  CountDown(8); // Pause for 8 seconds before the next message
        //}


    }
    

    

}