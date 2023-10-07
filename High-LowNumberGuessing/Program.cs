﻿using System.Transactions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses = 5;
            int userInput = 0;
            Random rng = new Random();
            int randomNumber = rng.Next(0, 100);

            while (guesses > 0)
            {
                
                Console.WriteLine("Guess a number from 0-100. You have " + guesses + " guesses left. Good luck");
                userInput = Int32.Parse(Console.ReadLine());

                if (userInput == randomNumber)
                {
                    Console.WriteLine("You guessed correctly");
                    break;
                }
                else
                {
                    if (guesses > 1)
                    Console.WriteLine("You guessed incorrectly, try again.");
                    guesses--;
                }
            }


        }
    }
}