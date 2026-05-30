using System;

class Program
{


    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // initialize reference and scripture objects
        Reference myReference = new Reference("Proverbs", 3, 5, 6);
        Scripture myScripture = new Scripture(myReference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct they paths.");

        //write welcome and initial scripture
        Console.WriteLine("My Scripture Memorizer Program");
        Console.WriteLine();
        Console.WriteLine(myScripture.GetDisplayText());
        //handle user input
        string txtResponse = "";
        Console.WriteLine("Press enter to continue or type Quit to finish: ");
        txtResponse = Console.ReadLine();
        //figure out what to do based on user input
        while (txtResponse != "Quit")
        {
            myScripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine("My Scripture Memorizer Program");
            Console.WriteLine();
            Console.WriteLine(myScripture.GetDisplayText());

            if (myScripture.isCompletelyHidden())
            {
                txtResponse = "Quit";
            }
            else
            {
                Console.WriteLine("Press enter to continue or type Quit to finish: ");
                txtResponse = Console.ReadLine();

            }
        }
    }
}
