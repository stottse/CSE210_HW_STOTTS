public class Journal{
   public List<Entry> Entries = new List<Entry>();
   public void DisplayEntries(){
        for (int i=0; i<Entries.Count(); i++){
            Console.WriteLine($"{Entries[i].Date} - {Entries[i].Prompt} - {Entries[i].DailyEntry}");
        }

   }
   public void LoadEntries(){
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string firstName = parts[0];
    string lastName = parts[1];
}

        }
    public void SaveEntries(string filename){

    string fileName = filename;

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
    // You can add text to the file with the WriteLine method

    for (int i=0; i<Entries.Count(); i++){
            outputFile.WriteLine($"{Entries[i].Date} - {Entries[i].Prompt} - {Entries[i].DailyEntry}");
    }
    // You can use the $ and include variables just like with Console.WriteLine
    string color = "Blue";
    outputFile.WriteLine($"My favorite color is {color}");
    }

    }
  
}