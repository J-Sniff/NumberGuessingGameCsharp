using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Lets add limitations to number of guesses. Maybe larger number range

namespace NumberGuessingGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool correctGuess = false;
			Random random = new Random();

			int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");

			while (!correctGuess)
			{
				Console.WriteLine("Please enter your guess.");
				int guess = Convert.ToInt32(Console.ReadLine()); 

				if (guess > randomNum)
				{
                    Console.WriteLine("Your guess was to high go ahead and try again.");

                }
				else if (guess < randomNum)
				{
					Console.WriteLine("Your guess was to low go ahead and try again.");
				}
				else
				{
                    Console.WriteLine("Nice guess!");
					correctGuess = true;
                }
			}

            Console.WriteLine("Congratz you have won!!");


            Console.ReadKey();
        }
	}
}
