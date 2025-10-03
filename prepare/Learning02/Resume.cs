public class Resume
{
public string Name;
public List <Jobs> job = new List<Jobs>();

public void DisplayResume()
    {
        Console.WriteLine($"Name:{Name}");
         Console.WriteLine("Jobs:");

        foreach (Jobs job in job)
        {
            job.ShowJobDetails();
            
        }
    }

}