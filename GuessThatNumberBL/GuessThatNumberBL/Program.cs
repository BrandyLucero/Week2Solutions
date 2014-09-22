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
                    Console.WriteLine("Number of guesses:" + numberOfGuesses);}

               }


            }  
            static void AddHighScore(int PlayerScore)
            {

            Console.WriteLine("Your Name");
            string playerName = Console.ReadLine();
            NORTHWNDEntities db = new NORTHWNDEntities();

            //create a new highscore
            HighScore newHighScore = new HighScore();
            newHighScore.Date = DateTime.Now;
            newHighScore.Game = "Trivia";
            newHighScore.Name = playerName;
            newHighScore.Score = PlayerScore;

            //add it to the data base

            db.HighScores.Add(newHighScore);

            //save changes 
            db.SaveChanges();
            

        }

        static void DisplayHighScore()
        {
            Console.WriteLine("Display Guess That Number High Score");
            Console.WriteLine("--------------");

            NORTHWNDEntities db = new NORTHWNDEntities();
            List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "Guess That Number")
                .OrderByDescending(x => x.Score).Take(10).ToList();

            foreach(HighScore highScore in highScoreList)
            {
                Console.WriteLine("{0}. {1}- {2} on {3}",
                highScoreList.IndexOf(highScore) + 1,
                highScore.Name,
                highScore.Score,
                highScore.Date.Value.ToShortDateString());

            }

        }

    }
}

    

