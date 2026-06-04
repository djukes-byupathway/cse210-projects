using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Program myProgram = new Program();

        Console.WriteLine("Welcome to the Mindfulness Program.");
        myProgram.DisplayMenu();
        int response = int.Parse(Console.ReadLine());

        while (response != 4)
        {
            if (response == 1)
            {
                Console.WriteLine("breathing activity not ready yet please select another"); // replace when breathing activity coding is done
            }
            else if (response == 2)
            {
                Console.WriteLine("reflecting activity not ready yet please select another"); // replace when breathing activity coding is done
            }
            else if (response == 3)
            {
                Console.WriteLine("listing activity not ready yet please select another"); // replace when breathing activity coding is done
            }
            else if (response == 4)
            {
                Console.WriteLine(); // replace when breathing activity coding is done
            }
            else
            {
                Console.WriteLine("Please Enter a valid option");  
            }


            myProgram.DisplayMenu();
            response = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("Goodby and have a great day!");
        Console.WriteLine();
    }
    
    public void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }
}

