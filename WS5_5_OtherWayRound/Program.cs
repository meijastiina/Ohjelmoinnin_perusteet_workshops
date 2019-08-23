using System;

namespace WS5_5_OtherWayRound
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for a string and then prints it out from the last character to the first. 
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string reversedInput = "";
            for (int i = input.Length - 1; i >= 0; i--) // Let's start from the last character and loop through to the first.
            {
                // You can access a character in a specific index by using square brackets (string name =”John”; name[0] =”J”).
                reversedInput += input[i];
            }
            Console.WriteLine(reversedInput);
        }
    }
}
