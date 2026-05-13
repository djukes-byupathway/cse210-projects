using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // get input
        Console.WriteLine("what is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        int modulus = percent % 10;

        //variable to host letter grade
        string letter = "";
        //variable to hold sign
        string sign = "";

        //find letter grade based on input
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //when determining grade +/- ignore A+ and F+/-
        if (percent <= 93 && percent >= 60)
        {
            //
            if (modulus >= 7)
            {
                sign = "+";
            }
            else if (modulus < 3)
            {
                sign = "-";
            }
        }

        //send letter grade to console
        Console.WriteLine($"Your grade is: {letter}{sign}");

        //determine if grade is passing and send message to console
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}