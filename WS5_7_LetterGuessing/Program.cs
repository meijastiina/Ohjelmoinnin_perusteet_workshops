using System;

namespace WS5_7_LetterGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks for a keyword and then a letter to be searched in the given string. 
            Console.Write("Keyword: ");
            string keyword = Console.ReadLine();
            string guessed = "";
            Console.Write("Guess a letter: ");
            char letter = char.Parse(Console.ReadLine());
            if (keyword.IndexOf(letter) == - 1)
            {
                Console.WriteLine($"{ letter } not found");
            }
            else {
                /* If the letter can be found in the string print out the given string so that only the guessed letter 
                 * is visible and all others are asterisks (*).*/
                for (int i = 0; i < keyword.Length; i++)
                {
                    if (keyword[i] == letter)
                    {
                        guessed += letter;
                    } else
                    {
                        guessed += "*";
                    }
                }
                Console.WriteLine(guessed);
            }
        }
    }
}
