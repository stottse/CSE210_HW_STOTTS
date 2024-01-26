using System;

public class Resume{
    public string _Name;
    public List<Job> _jobs = new List<Job>();
    public void Display(){
        Console.WriteLine($"{_Name}");
        Console.WriteLine("Job Experience:");
        foreach (Job job in _jobs){
            job.Display();
        }


    }


}