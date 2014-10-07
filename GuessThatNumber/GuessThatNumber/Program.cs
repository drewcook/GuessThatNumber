using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to play
            Console.WriteLine("Lets play GUESS THAT NUMBER!!!\n\nTry to find the correct number by typing in a number from 1 to 100.\n\n");

            //call our guessThatNumber function
            guessThatNumber();

            //keep console open
            Console.ReadKey(true);
        }

        //functions go here
        static void guessThatNumber()
        {
            

            //create randomnumbergenerator
            Random randNum = new Random();

            //claim variable for the computers pick of the number between 1 and 100
            int numberToGuess = randNum.Next(1, 100);

            //claim a variable for the number of guesses
            int numGuesses = 0;
            
            //claim a boolean as (false) to run our while loop
            bool hasWon = false;
            
            //create a loop while the user guess is true
            while (!hasWon)
            {
                //find the users input with .readline
                int Guess = int.Parse(Console.ReadLine());

                if (Guess > numberToGuess)
                {
                    Console.WriteLine("\nYou have guessed higher than the number. Keep guessing!\n\n");
                    numGuesses++;
                }
                else if (Guess < numberToGuess)
                {
                    Console.WriteLine("\nYou have guessed lower than the number. Keep guessing!\n\n");
                    numGuesses++;
                }
                else if (Guess == numberToGuess)
                {
                    numGuesses++;
                    Console.Clear();
                    Console.WriteLine("Congratulations!!! You have guessed the correct number.  Such a genius, you are!\n");
                    Console.WriteLine("It took you " + numGuesses + " guesses to find the number.");
                    hasWon = true;
                }

               
            }
            //game over

            Console.WriteLine("\n\n\nThank you for playing Guess That Number!!!");
            Console.WriteLine("\n\n\nPress any key to exit...");
            //AddHighScore(numGuesses);
            //DisplayHighScores();
            
        }


        ////add the highscores to the database
        //static void AddHighScore(int playerScore)
        //{
        //    //get the name for the player
        //    Console.WriteLine("\n\nYour name:\n");
        //    string playerName = Console.ReadLine();
            
        //    //create a gateway to the database
        //    spDrewEntities db = new spDrewEntities();
 
        //    //create a new highscore object
        //    HighScore newHighscore = new HighScore();
        //    newHighscore.DateCreated = DateTime.Now;
        //    newHighscore.Game = "Guess That Number";
        //    newHighscore.Name = playerName;
        //    newHighscore.Score = playerScore;

        //    //add it to the database
        //    db.HighScores.Add(newHighscore);


        //    //always save changes, but only need to type this one time
        //    db.SaveChanges();

        //}

        ////create a new function to display the highschore
        //static void DisplayHighScores()
        //{
        //    //tell user to view highscores
        //    Console.WriteLine("\n\nPress any key to view high scores...");
        //    //clear console everytime to show highscore on a blank screen
        //    Console.ReadKey();
        //    Console.Clear();
        //    //write the high score text
        //    Console.WriteLine("Guess That Number High Scores!");
        //    Console.WriteLine("==============================");
        //    //create a new connection to the database
        //    spDrewEntities db = new spDrewEntities();
        //    //get the high score list
        //    //pull from our HighScores database where the game is "Guess That Number, order by highest score, and only take the top 10 scores
        //    List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "Guess That Number").OrderBy(x => x.Score).Take(10).ToList();

        //    //make a foreach loop to print out these scores to the console
        //    foreach (var highScore in highScoreList)
        //    {
        //        Console.WriteLine("{0}. {1} - {2} on {3}", highScoreList.IndexOf(highScore) + 1, highScore.Name, highScore.Score, highScore.DateCreated);
        //    }
        //}
    }
}
