using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");


        // first create a list object to hold the numbers
        List<int> nums = new List<int>();

        int numEntered = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (numEntered != 0)
        {
            Console.WriteLine("Enter a number: ");
            string resp = Console.ReadLine();
            numEntered = int.Parse(resp);
            if (numEntered != 0)
            {
                nums.Add(numEntered);
            }

        } // end of while loop

        // -------------
        // do the maths
        // -------------

        // sum 
        int sumNums = 0;
        foreach (int num in nums)
        {
            sumNums += num;
        }
        //write results of sum
        Console.WriteLine($"The sum is: {sumNums}");

        // average
        // need to cast sumNums to float to get decimal results
        float avgNums = ((float)sumNums) / nums.Count;
        //write results of average
        Console.WriteLine($"The average is: {avgNums}");

        //max
        // loop through list and store greatest in variable 
        int maxNums = nums[0];

        foreach (int num in nums)
        {
            if (num > maxNums)
            {
                maxNums = num;
            }
        }
        //write results of max
        Console.WriteLine($"The max is: {maxNums}");

        // smallest positive number
        // loop through list and store greatest in variable 
        int lowestPosNums = 2147483647;

        foreach (int num in nums)
        {
            if (num < lowestPosNums && num > 0)
            {
                lowestPosNums = num;
            }
        }
        //write results of max
        Console.WriteLine($"The smallest positive number is: {lowestPosNums}");

        //print in sorted order
        nums.Sort();
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }

    } // end of main
} // end of program