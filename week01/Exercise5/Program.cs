using System;
using System.ComponentModel;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int numSq = SquareNumber(favNum);
        DisplayResult(name, numSq);

    } // End Main

    // DisplayWelcome
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    } // End DisplayWelcomeMessage

    // PromptUserName
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    } // End PromptUserName

    // PromptUserNumber
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string response = Console.ReadLine();
        int numEnt = int.Parse(response);
        return numEnt;
    } // End PromptUserNumber


    // SquareNumber
    static int SquareNumber(int num)
    {
        int numSq = num * num;
        return numSq;
    } // End of SquareNumber


    // DisplayResult
    static void DisplayResult(string name, int sqNum)
    {
        Console.WriteLine($"{name}, the square of your number is {sqNum}");
    } // end of DisplayResult







} // End Program