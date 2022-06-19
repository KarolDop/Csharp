using System;

public class Stopwatch
{
    private TimeSpan messuer;
    private DateTime start;
    private DateTime stop;
    private bool isRun = false;
    private int both = 0;



    public void Start()
    {
        try
        {
            if (isRun == true)
                throw new InvalidOperationException();
            start = DateTime.Now;
            isRun = true;
            both++;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Stop()
    {
        try
        {
            if(isRun == false)
                throw new InvalidOperationException();
            stop = DateTime.Now;
            messuer = stop - start;
            isRun = false;
            both++;
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Result()
    {
        if (both == 2)
        {
            Console.WriteLine($"Hours: {messuer.Hours};\tMinutes: {messuer.Minutes};\tSeconds: {messuer.Seconds};\tMiliseconds: {messuer.Milliseconds}");
            both = 0;
        }
    }
}
