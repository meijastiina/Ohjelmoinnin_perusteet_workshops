using System;

namespace WS5_9_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Hangman game.

            //1.Ask for a word to guess.
            Console.Write("Enter a word to guess: ");
            string keyword = Console.ReadLine();
            string guessed = "";

            // 4.Define a limit for guesses.
            int maxGuesses = 10; // if max number of guesses is reached -> game over
            int numberOfGuesses = 0; // counter for guesses
            Console.Clear(); // Let's clear out the console so that the word to be guessed is not visible. 

            for (int i = 0; i < keyword.Length; i++) // Loops through each character in keyword
            {
                guessed += "*"; // Let's initialize guessed with asterisks to begin with 
            }

            do
            {
                // 2.Ask for letters.
                Console.Write("Guess a letter: ");
                char letter = char.Parse(Console.ReadLine());
                // 3.Count how many guesses the user has had.
                numberOfGuesses++;

                for (int i = 0; i < keyword.Length; i++)
                {
                    if (keyword[i] == letter) // The letter guessed can be found in this index in the keyword
                    {
                        // Let's remove the * and insert the guessed letter
                        guessed = guessed.Remove(i, 1).Insert(i, letter.ToString()); 
                    }
                }
                Console.WriteLine(guessed);
                Console.WriteLine($"You have used { numberOfGuesses }/{ maxGuesses } guesses.");
            } while (numberOfGuesses < maxGuesses && !keyword.Equals(guessed, StringComparison.CurrentCultureIgnoreCase));
            /* 5.Game ends when
             *  a.the word is guessed
             *  b.	or the limit for guesses is reached
             */
            if ( numberOfGuesses >= maxGuesses )
            {
                // Max number of guesses reached
                Console.WriteLine("Maximum number of guesses reached! GAME OVER");
            }
            else
            {
                // The whole word is guessed
                Console.WriteLine($"YOU WIN! You needed { numberOfGuesses } guesses to get the word.");
            }
        }
    }
}
