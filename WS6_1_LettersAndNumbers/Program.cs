using System;

namespace WS6_1_LettersAndNumbers
{
    class Program
    {
        // Create a program with three methods:
        // 1.	main

        static void Main(string[] args)
        {
            // In your main method, call first printLetters() method,
            printLetters();
            //  then printNumbers() 
            printNumbers();
            // and after that printLetters() again.
            printLetters();
        }
        // 2.	printLetters() : prints letters from a-z
        private static void printLetters()
        {
            Console.WriteLine("abcdefghijklmnopqrstuvwxyz");
        }
        // 3.	printNumbers() : prints numbers from 1-9
        private static void printNumbers()
        {
            Console.WriteLine("123456789");
        }
    }
}
