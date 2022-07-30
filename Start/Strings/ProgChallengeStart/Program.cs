using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            bool keepPlaying = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // taking input from the user


            // Keep track of the number of guesses and the current user guess
            int guessNum = 0;
            int guessCount = 0;

            // Start the game and run until user quits or guesses correctly
            do
            {
                // Ask the user for their input
                Console.WriteLine("What's your guess?");

                string userInput = Console.ReadLine();
                bool result = Int32.TryParse(userInput, out guessNum);

                // Check if the user entered something other than number
                if (!result)
                {
                    Console.WriteLine("Hmmm, that doesn't look like a number. Please try again and enter a number");
                }
                else
                {
                    // if the user entered -1 to exit the game
                    if (guessNum == -1)
                    {
                        Console.WriteLine($"Oh well. I was thinking of {theNumber}");
                        keepPlaying = false;
                    }
                    else
                    {
                        // Increase the guess count
                        guessCount++;

                        // If the user got it right, tell the user the nt and exit
                        if (guessNum == theNumber)
                        {
                            Console.WriteLine($"You got it in {guessCount} guesses!!");
                            keepPlaying = false;
                        }
                        else
                        {
                            // Tell the user to guess lower or higher than the previous number
                            Console.WriteLine("Nope, {0} than that", guessNum < theNumber ? "higher" : "lower");

                        }
                    }
                }

            } while (keepPlaying);

        }
    }
}
