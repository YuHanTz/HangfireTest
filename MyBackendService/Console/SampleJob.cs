namespace MySchedulerProject.Jobs;

public class SampleJob
{
    public void Run()
    {
        Console.WriteLine($"[{DateTime.Now}] SampleJob is running.");
    }
}
