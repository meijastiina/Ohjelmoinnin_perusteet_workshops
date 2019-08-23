using System;

namespace WS6_2_LoremIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            printLoremIpsumTenTimes();
        }
        // Create a method that prints out Lorem ipsum sentence (”Lorem Ipsum dolor sit amet, consectetur adipiscing elit. ”) ten times.
        private static void printLoremIpsumTenTimes()
        {
            for (int i = 0; i < 10; i++)
            {
                // Further improve your program so that instead of printing directly in the loop in your method, it calls another method that prints the sentence.
                printLoremIpsum(); 

            }
        }
        
        private static void printLoremIpsum()
        {
            Console.WriteLine("Lorem Ipsum dolor sit amet, consectetur adipiscing elit.");
        }
    }
}
