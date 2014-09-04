using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumberBL
{
    class Program
    {

        static void Main(string[] args)
        {
            //Generate a random number to be guessed
            Random rnd = new Random();
            int numberToGuess = rnd.Next(100) + 1;
            int userGuess = 0;
            int numberOfGuesses = 0;
            //loop for guessing numbers
            while (userGuess != numberToGuess)
            {
                //add up the number of guesses
                numberOfGuesses++;
                //output to user
                Console.WriteLine("Enter your guess: ");
                int.TryParse(Console.ReadLine(), out userGuess);
                Console.ReadLine();
                //user guess a number
                if (userGuess > numberToGuess)
                {
                    //if guess is higher than the random number
                    Console.WriteLine(userGuess + "is too high. Try again!" );
                }
                else if (userGuess < numberToGuess)
                {
                    ////if guess is lower than the random number
                    Console.WriteLine(userGuess + "is too low. Try again!");
                }
                else
                {
                    //if user gets correct anser output
                    Console.WriteLine(userGuess + "is right! Congratulations.");
                    //output number of guesses
                    Console.WriteLine("Number of guesses:" + numberOfGuesses);
                }

            }

        }

    }
}

    

