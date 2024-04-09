using System;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activities = new List<Activity>();
        Running runningActivity = new Running("2024-04-10", 30, 4.5);
        Swimming swimmingActivity = new Swimming("2024-04-09", 40.0, 16);
        Cycling cyclingActivity = new Cycling("2024-04-08", 60, 15);
        activities.Add(runningActivity);
        activities.Add(swimmingActivity);
        activities.Add(cyclingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());

        }

    }
}