// See https://aka.ms/new-console-template for more information
public class Stopwatch
{
    DateTime StartTime;
    DateTime StopTime;
    public void Start()
    {
        StartTime = DateTime.Now;
        
    }

    public void Stop()
    {
         StopTime = DateTime.Now;

    }

    public void difference()
    {
        TimeSpan difference =  StopTime- StartTime ;
        Console.WriteLine("{0} seconds", difference.Seconds);
    }
}