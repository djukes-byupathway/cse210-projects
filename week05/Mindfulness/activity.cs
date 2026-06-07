public class Activity
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;

    //behavior or methods     
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name} Activity;");
        Console.WriteLine();
        Console.WriteLine(Description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity,");
        ShowSpinner(5);
        Console.Clear();

    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
      
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int listIndex = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[listIndex]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            listIndex++;
            if (listIndex >= animationString.Count)
            {
                listIndex = 0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        for(int i=seconds;i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


//public getter setter methods for properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }


}