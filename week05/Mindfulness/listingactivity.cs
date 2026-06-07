using System.Collections.Generic;
public class ListingActivity : Activity
{
    //attributes
    private int _count;
    private List<string> _prompts =
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];

    //constructor
    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Duration = 50;

    }

    //behaviors or methods
    public void Run()
    {
        DisplayStartingMessage();
        Duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready");
        ShowSpinner(5);
        Console.WriteLine();
        List<string> strings = GetListFromUser();
        Console.WriteLine($"You listed {strings.Count()} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rng = new Random();
        int randomIndex = rng.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];

        return $"--- {prompt} ---";
    }

    public List<string> GetListFromUser()
    {
        List<string> myStrings = [];

        Console.WriteLine("List as many responses yan can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(3);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            // Need to Show Random Question
            Console.Write(">");
            myStrings.Add(Console.ReadLine());
            Console.WriteLine();

        }

        return myStrings; //note this is not the final returned value
    }
}
