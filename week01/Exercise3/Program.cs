using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("What is the magic number? ");
        // int magicNum = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();

        bool playOn = true;

        while (playOn)
        {



            int magicNum = randomGenerator.Next(1, 101);
            int guess = -1;
            int numGuesses = 0;

            // We could also use a do-while loop here...
            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;
                if (magicNum > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNum < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {numGuesses} guesses!");
                    Console.Write("Would you like to play again? (Y/N) ");
                    string doAgain = Console.ReadLine();

                    // found the next commented line and want to use this for checking if they want to play again
                    //bool areEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase)
                    playOn = doAgain.Equals("Y", StringComparison.OrdinalIgnoreCase);
                }



            }
        }
    }
}