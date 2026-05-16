using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator newPrompts = new PromptGenerator();
        string today = DateTime.Now.ToShortDateString();
        Journal myJournal = new Journal();
        // Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome to the Journal Program!");

        int option = 0;

        while (option != 5)
        {
            DisplayOptions();
            option = int.Parse(Console.ReadLine());
            if (option == 1)
            {

                Console.WriteLine();
                // Console.WriteLine("You Select 1. Write");
                string prompt = newPrompts.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.WriteLine("");
                string respText = Console.ReadLine();
                //Console.WriteLine(respText);

                Entry newEntry = new Entry();
                newEntry._date = today;
                newEntry._promptText = prompt;
                newEntry._entryText = respText;
                //Console.WriteLine(newEntry._entryText);
                newEntry.Display();
                myJournal.AddEntry(newEntry);

            }
            else if (option == 2)
            {
                Console.WriteLine("");
                // Console.WriteLine("You Selected 2. Display");
                myJournal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.WriteLine("");
                Console.WriteLine("You Selected 3. Load");
                Console.WriteLine("");
            }
            else if (option == 4)
            {
                Console.WriteLine("");
                Console.WriteLine("You Selected 4. Save");
                Console.WriteLine("");
            }
            else if (option == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("You Selected 5. Quit");
                Console.WriteLine("");
            }
        }



    } // end main()

    static void DisplayOptions()
    {
        Console.WriteLine("Please select on of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
    } // end of DisplayOptions()

    // static void DisplayInitialPrompt() { }
    // static void DisplayInitialPrompt() { }
    // static void DisplayInitialPrompt() { }
    // static void DisplayInitialPrompt() { }
}