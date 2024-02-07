public class Journal{
   public List<Entry> Entries = new List<Entry>();
   public void DisplayEntries(){
        for (int i=0; i<Entries.Count(); i++){
            Console.WriteLine($"{Entries[i].Date} - {Entries[i].Prompt} - {Entries[i].DailyEntry}");
        }

   }
   public void LoadEntries(){

   }
   public void SaveEntries(){

   }
   public void AddEntries(){

   }
}