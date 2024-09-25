public class Resume
{
    public string name;
    public List<Job>_jobs = new List<Job>();

    public void DisplayMyResume()
    {
        Console.WriteLine($"Name: {name}\nJobs:");

        foreach (Job j in _jobs)
        {
            j.DisplayJobInfo();
        }
    }

}