using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumberGuessingGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			bool correctGuess = false;			
			int randomNum = random.Next(1, 11);
			int guessLimit = 0;

			Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");

			while (!correctGuess && guessLimit < 3)
			{
				Console.WriteLine("Please enter your guess.");
				int guess = Convert.ToInt32(Console.ReadLine());
				guessLimit++;

				if (guess > randomNum)
				{
                    Console.WriteLine("Your guess was to high go ahead and try again.");
                }
				else if (guess < randomNum)
				{
					Console.WriteLine("Your guess was to low go ahead and try again.");
				}
				else if (guess == randomNum)
				{
                    Console.WriteLine("Nice guess! You win!!");
					Console.WriteLine("Would you like to play again? (y/n)");
					string playAgain = Console.ReadLine();

					// Ask the user if they want to play again
					if (playAgain == "y")
					{
						randomNum = random.Next(1, 11);
						correctGuess = false;
						guessLimit = 0;
					}
					else if (playAgain == "n")
					{
						correctGuess = true;
					}
				}
				// Adding a limit of 3 guesses	
				if (guessLimit == 3)
				{
					Console.WriteLine("Sorry you have reached the guess limit.");
					Console.WriteLine("Would you like to play again? (y/n)");
					string playAgain = Console.ReadLine();

					if (playAgain == "y")
					{
						randomNum = random.Next(1, 11);
						correctGuess = false;
						guessLimit = 0;
					}
					else if (playAgain == "n")
					{
						correctGuess = true;
					}
				}
            }  
			Console.WriteLine("Thanks for playing!");
			Console.ReadLine();	
        }
	}
}
