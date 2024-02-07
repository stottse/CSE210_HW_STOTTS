public class Entry{
    public string DailyEntry;
    public string Date;

    public string Prompt;

    public Entry(string randomPrompt){
        Prompt = randomPrompt;

    }
    //The following is the method that will allow the user to display entries
    public void EnterEntry(){
        Console.WriteLine("Entry here:");
        DailyEntry = Console.ReadLine();
        Console.WriteLine("Please enter the date of the entry:");
        Date = Console.ReadLine();


    }
}