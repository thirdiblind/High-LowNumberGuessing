namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_GUESSES = 5;
            const int CLOSE_RANGE = 5;
            const int RMIN = 0;
            const int RMAX = 101;

            int guessesRemaining = MAX_GUESSES;
            int userInput = 0;
            Random rng = new Random();
            int randomNumber = rng.Next(RMIN, RMAX);

            while (guessesRemaining > 0)
            {

                Console.WriteLine($"Guess a number from " + RMIN + " to " + (RMAX - 1) + $". You have {guessesRemaining} left. Good luck!");
                userInput = Int32.Parse(Console.ReadLine());

                if (userInput == randomNumber)
                {
                    Console.WriteLine("You guessed correctly.");
                    break;
                }

                if (guessesRemaining > 0)
                {
                    if (Math.Abs(userInput - randomNumber) <= CLOSE_RANGE)
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
            if (userInput != randomNumber) Console.WriteLine($"Sorry, you've run out of guesses. The correct number was {randomNumber}.");
        }
    }
}