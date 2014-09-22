using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanBL
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            int width = Console.WindowWidth;
            width = width + 20;
            Console.WindowWidth = width;
            Hangman();
            Console.ReadKey();
        }
        static void Hangman()
        {
            //obligatory comment that will suffice for the entire code.
            Console.WriteLine("Welcome! Please enter your name before we begin.");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to the game, " + name + "!");
            Console.WriteLine("\n\n You will be playing Hangman today!. If you haven't played, you will be guessing letters of a randomly generated word until you can guess the full word, or all of the letters. \n\n\n\n");

            string[] words = new string[6] {"Football" , "Baseball", "Soccer", "Dance", "Lacross", "Hockey"};

            Random soHung = new Random();

            string randomWord = words[soHung.Next(0, words.Length + 1)];{


            bool won = false;

            int guessesLeft = 6;

            string lettersGuessed = string.Empty;

            while (!won)
            {
               
               Console.WriteLine(masky);
               Console.WriteLine();
               string guess = Console.ReadLine().ToLower();
               
               if (guess.Length == 1)
               {
                   //letter guess
                   if (randomWord.Contains(guess))
                   {
                       Console.Clear();
                       Console.WriteLine("Good job! Keep guessing.\n");
                       lettersGuessed += guess;
                       Console.WriteLine("You have " + guessesLeft + " guesses left.\n");
                       Console.WriteLine("You've guessed these letters. \n " + lettersGuessed + "\n");
                   }
                   else
                   {
                       Console.Clear();
                       Console.WriteLine("Terrible. You're so bad. Keep going.\n\n");
                       guessesLeft--;
                       Console.WriteLine("You have " + guessesLeft + " guesses left.\n");
                       lettersGuessed += guess;
                       Console.WriteLine("You've guessed these letters. \n " + lettersGuessed + "\n");

                   }
               }
               else
               {
                   //word guess
                   if (guess == randomWord)
                   {
                       Console.Clear();{


                    static void AddHighScore(int PlayerScore)

        {
            Console.WriteLine("Your Name");
            string playerName = Console.ReadLine();
            NORTHWNDEntities db = new NORTHWNDEntities();

            //create a new highscore
            HighScore newHighScore = new HighScore();
            newHighScore.Date = DateTime.Now;
            newHighScore.Game = "Dragon Combat";
            newHighScore.Name = playerName;
            newHighScore.Score = PlayerScore;

            //add it to the data base

            db.HighScores.Add(newHighScore);

            //save changes 
            db.SaveChanges();
            

        }

        static void DisplayHighScore()
        {
            Console.WriteLine("Display Dragon Combat High Score");
            Console.WriteLine("--------------");

            NORTHWNDEntities db = new NORTHWNDEntities();
            List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "Dragon Combat")
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



         

