using System;

namespace WS5_6_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that lets the user know whether the string they entered is a palindrome or not.
            Console.Write("Enter a string: ");
            // This stuff can be copied from the previous workshop.
            string input = Console.ReadLine(); 
            string reversedInput = "";
            for (int i = input.Length - 1; i >= 0; i--) // Let's start from the last character and loop through to the first.
            {
                // You can access a character in a specific index by using square brackets (string name =”John”; name[0] =”J”).
                reversedInput += input[i];
            }
            // Let's use a ternary operator for a change instead of if/else
            string result = reversedInput.Equals(input, StringComparison.CurrentCultureIgnoreCase) ? $"{ input } is a palindrome!" : $"{ input } is NOT a palindrome!";
            Console.WriteLine(result);
        }
    }
}
