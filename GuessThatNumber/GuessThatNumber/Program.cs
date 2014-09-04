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
            guessThatNumber("\n");

            //keep console open
            Console.ReadKey(true);
        }

        //functions go here
        static void guessThatNumber(string input)
        {
            //find the users input with .readline
            int Guess = int.Parse(Console.ReadLine());

            //create randomnumbergenerator
            Random randNum = new Random();

            //claim variable for the computers pick of the number between 1 and 100
            int numberToGuess = randNum.Next(1, 100);

            //claim a variable for the number of guesses
            int numGuesses = 0;
            
            //claim a boolean as true to run our while loop
            bool boolGuess = true;
            
            //create a loop while the user guess is true
            while (boolGuess)
            {
                if (Guess > numberToGuess)
                {
                    Console.WriteLine("You have guessed higher than the number. Keep guessing!\n\n");
                    numGuesses++;
                }
                else if (Guess < numberToGuess)
                {
                    Console.WriteLine("You have guessed lower than the number. Keep guessing!\n\n");
                    numGuesses++;
                }
                else
                {
                    numGuesses++;
                    Console.WriteLine("Congratulations!!! You have guessed the correct number.  Such a genius, you are!\n");
                    Console.WriteLine("It took you " + numGuesses + " guesses to find the number.");
                }
                break;
                
            }

            
        }
    }
}
