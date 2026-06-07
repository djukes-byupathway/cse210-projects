using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine();
        Assignment myAssignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(myAssignment1.GetSummary());
        Console.WriteLine();

        MathAssignment myAssignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(myAssignment2.GetSummary());
        Console.WriteLine(myAssignment2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment myAssignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(myAssignment3.GetSummary());
        Console.WriteLine(myAssignment3.GetWritingInfo());
        Console.WriteLine();

    }
}