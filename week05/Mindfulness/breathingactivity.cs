using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{
    //attributes or properties
    // none


    //constructor
    public BreathingActivity()
    {
        Name = "Breathing";
        Description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Duration = 50;

    }

    public BreathingActivity(int duration)
    {
        Name = "Breathing";
        Description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Duration = duration;

    }

    // behavior or methods
    public void Run()
    {
        DisplayStartingMessage();
        Duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready");
        ShowSpinner(5);

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);
        int iteration  = 2;
        while (DateTime.Now < endTime)
        {
            if (iteration %2 == 0)
            {
                Console.Write("Breathe in...");
                ShowCountDown(4);
                Console.WriteLine();
            } else
            {
                Console.Write("Now breathe out...");
                ShowCountDown(5);
                Console.WriteLine();
            }
            iteration++;            
        }
        DisplayEndingMessage();
    }






}