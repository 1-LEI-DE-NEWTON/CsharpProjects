
using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int winningNumber = random.Next(1, 100);
            bool win = false;
            do 
            {
                // Ask the user to guess a number
                Console.WriteLine("Guess a number between 1 and 100");
                string s = Console.ReadLine();
                int guess = int.Parse(s);
                if (guess == winningNumber)
                {
                    Console.WriteLine("You win!");
                    win = true;
                }
                else if (guess < winningNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (guess > winningNumber)
                {
                    Console.WriteLine("Too high!");
                }
            } while (win == false);
        }
    }
}
