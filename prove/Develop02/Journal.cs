
public class Journal{
   public List<Entry> Entries = new List<Entry>();
   public void DisplayEntries(){
        for (int i=0; i<Entries.Count(); i++){
            Console.WriteLine($"{Entries[i].Date} - {Entries[i].Prompt} - {Entries[i].DailyEntry}");
        }

   }
   //The following is the method that will allow the user to load entries
   public void LoadEntries(string filename){
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
{
    string[] parts = line.Split("-");

    string date = parts[0].Trim();
    string prompt = parts[1].Trim();
    string dailyEntry = parts[2].Trim();

    Entry entry = new Entry(prompt);
    entry.Date = date;
    entry.DailyEntry = dailyEntry;
    Entries.Add(entry);
}

        }
        //The following is the method that will allow the user to save entries
    public void SaveEntries(string filename){

    string fileName = filename;

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
    

    for (int i=0; i<Entries.Count; i++){
            outputFile.WriteLine($"{Entries[i].Date} - {Entries[i].Prompt} - {Entries[i].DailyEntry}");
    }
    
    }

    }
  
}