using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        // Outer loop to restart the entire game if the user says "yes"
        while (playAgain.ToLower() == "yes")
        {
            Random random = new Random();
            int magicnumber = random.Next(1, 101);

            int guess = -1;
            int guessCount = 0; // Tracks the number of guesses

            // Inner loop for the current game session
            while (guess != magicnumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++; // Increment the count with each guess

                if (guess < magicnumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicnumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask the user if they want to play again after winning
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
            Console.WriteLine(); // Prints a blank line for clean spacing between games
        }

        Console.WriteLine("Thank you for playing!");
    }
}
