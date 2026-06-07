using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        DisplayMenu();
        int response = int.Parse(Console.ReadLine());

        while (response != 4)
        {
            if (response == 1)
            {
                BreathingActivity myBreathing = new BreathingActivity();
                myBreathing.Run();
            }
            else if (response == 2)
            {
                ReflectingActivity myReflecting = new ReflectingActivity();
                myReflecting.Run();
            }
            else if (response == 3)
            {
                ListingActivity myListing = new ListingActivity();
                myListing.Run();
            }
            else if (response == 4)
            {
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine("Please Enter a valid option");
            }

            DisplayMenu();
            response = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Goodbye and have a great day!");
        Console.WriteLine();
    }
    
    
    static public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mindfulness Program.");
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }
}

