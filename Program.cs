using System;


namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess your secret number");

            int SecretNumber = 42;
            int guessAllowance = 4;
            int userTries = 0;

            while (userTries < guessAllowance)
            {
                int response = int.Parse(Console.ReadLine());
                userTries++;

                if (response == SecretNumber)
                {
                    Console.WriteLine("Your guess is correct!");
                    break;
                }
                else if (userTries < guessAllowance)
                {
                    Console.WriteLine($"This is your {userTries} guess. Guess again");
                }
                else
                {
                    Console.WriteLine("You failed");
                }

            }
        }
    }
}

//for (int i=0; i < 4; i++)
