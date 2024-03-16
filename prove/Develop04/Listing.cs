public class ListingActivity : Activity
{
    private List<string> prompt = new List<string>();
    private int _itemsInput;

    public ListingActivity(string activityName, string description) : base(activityName, description) 
    {
        _activityName = activityName;
        _description = description;
        

        //List for prompts
        prompt.Add("Who are people that you appreciate?");
        prompt.Add("What are personal strengths of yours?");
        prompt.Add("Who are people that you have helped this week?");
        prompt.Add("When have you felt the Holy Ghost this month?");
        prompt.Add("Who are some of your personal heroes?");
        
    }

    public void Listing_Time()
    {
        CountDown(5);

        //Get a random prompt
        Random random = new Random ();
        int randomIndex = random.Next(0,prompt.Count);
        Console.WriteLine(prompt[randomIndex]);
        CountDown(9);

        //initial value for number of inputs
        _itemsInput = 0;


        Console.WriteLine(_duration);


        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);


        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {       
            Console.WriteLine();
            Console.Write("List item:");
            Console.ReadLine();
            _itemsInput +=1 ;
            currentTime = DateTime.Now;
        }
        
        Console.WriteLine($"You listed {_itemsInput} things.");

    }
    
}