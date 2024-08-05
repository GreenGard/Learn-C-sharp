using System;

namespace GuessGame 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gamerGuessing = true;
            Random randomNumber = new Random();

            int randomNum = randomNumber.Next(1, 101);

            Console.WriteLine("The number guessing game");
            Console.WriteLine("In this game you will guess a number between 1 and 100. If you guess the right number, you win!");

            while (gamerGuessing)
            {
                Console.WriteLine("Add a number:");
                string input = Console.ReadLine();

                int guess;

                if (int.TryParse(input, out guess))
                {
                    if (guess != randomNum)
                    {
                        Console.WriteLine("Sorry, it's not the right number, please try again");
                    }
                    else
                    {
                        Console.WriteLine("Congrats! You are the winner");
                        gamerGuessing = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Wait for user to press a key before closing
        }
    }
}
