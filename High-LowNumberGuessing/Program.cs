using System.Transactions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GUESSES_INITIAL_AMOUNT = 5;
            int guessesRemaining = GUESSES_INITIAL_AMOUNT;
            int userInput = 0;
            Random rng = new Random();
            int randomNumber = rng.Next(0, 100);

            while (guessesRemaining > 0)
            {

                Console.WriteLine($"Guess a number from 0-100. You have {guessesRemaining} left. Good luck!");
                userInput = Int32.Parse(Console.ReadLine());

                if (userInput == randomNumber)
                {
                    Console.WriteLine("You guessed correctly.");
                    break;
                }
                if (guessesRemaining > 0)
                {
                    if (Math.Abs(userInput - randomNumber) <= 5)
                    {
                        Console.WriteLine("You're close!!");
                    }
                    if (userInput > randomNumber)
                    {
                        Console.WriteLine("You guessed incorrectly. The number you guessed was too high.");
                    }
                    if (userInput < randomNumber)
                    {
                        Console.WriteLine("You guessed incorrectly. The number you guessed was too low.");
                        
                    }
                    guessesRemaining--;
                }

            }
            if (guessesRemaining == 0)
            {
                Console.WriteLine($"Sorry, you've run out of guesses. The correct number was {randomNumber}.");
            }

        }
    }
}