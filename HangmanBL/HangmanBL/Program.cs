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
            Console.WriteLine("\n\n You will be playing Hangman today!.\nIf you haven't played, you will be guessing\nletters of a randomly generated word until you can guess the full word,\nor all of the letters. \n\n\n\n");

            string[] words = new string[30] {"broncos" , "cardinals", "seahawks", "redskins", "bears", "panthers", "texans","cowboys","bills","lions", "ravens","colts","steelers", "jaguars","buccaneers","saints",
                "falcons","giants","rams","eagles","browns","titans","jets","chargers","chiefs", "fourtyniners","bengals","patriots","vikings", "packers"};

            Random soHung = new Random();

            string randomWord = words[soHung.Next(0, words.Length + 1)];

            bool won = false;

            int guessesLeft = 6;

            string lettersGuessed = string.Empty;

            while (!won)
            {
               string masky = MaskWord(randomWord,lettersGuessed);
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
                       Console.Clear();
                       Console.WriteLine(@"
__     __                                             _                       _ 
\ \   / /                                            (_)                     | |
 \ \_/ /__  _   _    __ _ _ __ ___    __ _  __      ___ _ __  _ __   ___ _ __| |
  \   / _ \| | | |  / _` | '__/ _ \  / _` | \ \ /\ / / | '_ \| '_ \ / _ \ '__| |
   | | (_) | |_| | | (_| | | |  __/ | (_| |  \ V  V /| | | | | | | |  __/ |  |_|
   |_|\___/ \__,_|  \__,_|_|  \___|  \__,_|   \_/\_/ |_|_| |_|_| |_|\___|_|  (_)
                                                                                  " + "\n\n");

                       Console.WriteLine("You had" + guessesLeft + " guess(es) left. \n");
                       Console.WriteLine("The word to guess was: " + randomWord);
                       won = true;
                   }
                   else if (guess != randomWord)
                   {
                       Console.Clear();
                       Console.WriteLine("Incorrect, guess again.\n");
                       guessesLeft--;
                       Console.WriteLine("You have " + guessesLeft + " guesses left.\n");
                       Console.WriteLine("You've guessed these letters. \n " + lettersGuessed + "\n");
                   }

               }
               if (guessesLeft == 0)
               {
                   Console.Clear();
                   won = true;
                   Console.WriteLine(@"
   ____                        __     __           _                    
 / ____|                       \ \   / /          | |                   
| (___   ___  _ __ _ __ _   _   \ \_/ /__  _   _  | |     ___  ___  ___ 
 \___ \ / _ \| '__| '__| | | |   \   / _ \| | | | | |    / _ \/ __|/ _ \
 ____) | (_) | |  | |  | |_| |    | | (_) | |_| | | |___| (_) \__ \  __/
|_____/ \___/|_|  |_|   \__, |    |_|\___/ \__,_| |______\___/|___/\___|
                         __/ |                                          
                        |___/   
                                                                                         
                                                                                         " + "\n\n");
                   Console.WriteLine("The word to guess was: " + randomWord);
               }
               if (guessesLeft == 5)
               {
                   Console.WriteLine(@"
           |/|
           |/|
           |/|
           |/|
           |/|
           |/|");
               }
               else if (guessesLeft == 4)
               {
                   Console.WriteLine(@"  
           |/|
           |/|
           |/|
           |/|
           |/|
           |/|
           |/| /¯)
           |/|/\/
           |/|\/");
               }
               else if (guessesLeft == 3)
               {
                   Console.WriteLine(@"    
           |/|
           |/|
           |/|
           |/|
           |/|
           |/|
           |/| /¯)
           |/|/\/
           |/|\/
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
");
               }
               else if (guessesLeft == 2)
               {
                   Console.WriteLine(@"   
           |/|
           |/|
           |/|
           |/|
           |/|
           |/|
           |/| /¯)
           |/|/\/
           |/|\/
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          /¯¯/\
         / ,^./\
        / /   \/\
       / /     \/\");
               }
               else if (guessesLeft == 1)
               {
                   Console.WriteLine(@"   
           |/|
           |/|
           |/|
           |/|
           |/|
           |/|
           |/| /¯)
           |/|/\/
           |/|\/
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          /¯¯/\
         / ,^./\
        / /   \/\
       / /     \/\
      ( (       )/)
      | |       |/|
      | |       |/|
      | |       |/|");
               }
               else if (guessesLeft == 0)
               {
                   Console.WriteLine(@"    
           |/|
           |/|
           |/|
           |/|
           |/|
           |/|
           |/| /¯)
           |/|/\/
           |/|\/
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          (¯¯¯)
          /¯¯/\
         / ,^./\
        / /   \/\
       / /     \/\
      ( (       )/)
      | |       |/|
      | |       |/|
      | |       |/|
      ( (       )/)
       \ \     / /
        \ `---' /
         `-----' ");
               }
               if (masky == randomWord)
               {
                   Console.Clear();
                   Console.WriteLine(@"_
\ \   / /                                            (_)                     | |
 \ \_/ /__  _   _    __ _ _ __ ___    __ _  __      ___ _ __  _ __   ___ _ __| |
  \   / _ \| | | |  / _` | '__/ _ \  / _` | \ \ /\ / / | '_ \| '_ \ / _ \ '__| |
   | | (_) | |_| | | (_| | | |  __/ | (_| |  \ V  V /| | | | | | | |  __/ |  |_|
   |_|\___/ \__,_|  \__,_|_|  \___|  \__,_|   \_/\_/ |_|_| |_|_| |_|\___|_|  (_)
                                        
                                        " + "\n\n");
                   Console.WriteLine("You had " + guessesLeft + " guess(es) left.\n");
                   Console.WriteLine("The word to guess was: " + randomWord);
                   won = true;
               }



            }
            //add to high scores
            AddHighScore(guessesLeft);
            //Display highscores
            DisplayHighScores();


        }
        static string MaskWord(string randomWord, string lettersGuessed)
        {
            string returnString = string.Empty;

            int guessesLeft = 6;

            for (int i = 0; i < randomWord.Length; i++)
            {
                char letter = randomWord[i];

                if (lettersGuessed.Contains(letter.ToString()))
                {
                    returnString = returnString + letter;
                }
                else
                {
                    returnString = returnString + "_ ";
                    guessesLeft--;
                }
            }
            return returnString;
        }

        //add the highscores to the database
        static void AddHighScore(int playerScore)
        {
            //get the name for the player
            Console.WriteLine("\n\nYour name:\n");
            string playerName = Console.ReadLine();

            //create a gateway to the database
            BrandyEntities db = new BrandyEntities();

            //create a new highscore object
            HighScore newHighscore = new HighScore();
            newHighscore.Date = DateTime.Now;
            newHighscore.Game = "Hangman";
            newHighscore.Name = playerName;
            newHighscore.Score = playerScore;

            //add it to the database
            db.HighScores.Add(newHighscore);


            //always save changes, but only need to type this one time
            db.SaveChanges();

        }

        //create a new function to display the highschore
        static void DisplayHighScores()
        {
            //tell user to view highscores
            Console.WriteLine("\n\nPress any key to view high scores...");
            //clear console everytime to show highscore on a blank screen
            Console.ReadKey();
            Console.Clear();
            //write the high score text
            Console.WriteLine("Hangman High Scores!");
            Console.WriteLine("==============================");
            //create a new connection to the database
            BrandyEntities db = new BrandyEntities();
            //get the high score list
            //pull from our HighScores database where the game is "Guess That Number, order by highest score, and only take the top 10 scores
            List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "Hangman").OrderBy(x => x.Score).Take(10).ToList();

            //make a foreach loop to print out these scores to the console
            foreach (var highScore in highScoreList)
            {
                Console.WriteLine("{0}. {1} - {2} guesses left on {3}", highScoreList.IndexOf(highScore) + 1, highScore.Name, highScore.Score, highScore.Date);
            }
        }

    }
}