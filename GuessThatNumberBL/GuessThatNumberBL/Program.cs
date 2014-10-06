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
            //ask the user ti play
            Console.WriteLine("Welcome to GUESS THAT NUMBER!\nYou are to guess the number\nI have chosen to be the magic number\nby typing a number from 1 to 100.\n\n");

            guessThatNumber();

            //keep the console open 
            Console.ReadKey(true);
        }
        static void guessThatNumber()
        {

            //Generate a random number to be guessed using a randon generator

            Random rnd = new Random();
            //claim variables for the computers pick of the number between 1 and 100
            int numberToGuess = rnd.Next(100) + 1;
            //clai a variable for the number of guesses

            int numberOfGuesses = 0;

            //claim a boolean as (false) to run our while loop.
            bool hasWon = false;
            //loop for guessing numbers
            while (!hasWon)
            {
                //find users input with readline
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("\nNumber is too High. Try again!\n");
                    numberOfGuesses++;

                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("\nNumber is too Low. Try again!\n");
                    numberOfGuesses++;

                }
                else if (userGuess == numberToGuess)
                {
                    numberOfGuesses++;
                    Console.Clear();
                    Console.WriteLine("Congratulations! You are a winner! You have guessed my number!");
                    Console.WriteLine("It took you " + numberOfGuesses + " guesses to find the number.");
                    hasWon = true;
                }
            }
        }
    }
}

  
 
  

    

