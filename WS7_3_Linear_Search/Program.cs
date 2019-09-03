using System;

namespace WS7_3_Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.	Create two arrays with the following items:
            // a.  55, 23, 6456, 324, 21, 234, 72, 21
            int[] integerArray = new int[8] { 55, 23, 6456, 324, 21, 234, 72, 21 };
            // b., Kauko, Matti, Minna, Maisa, Juuso, Mauno
            string[] stringArray = new string[7] { "Petteri", "Kauko", "Matti", "Minna", "Maisa", "Juuso", "Mauno" };
            // 2.Ask the user what they want to search for in the integer array.
            Console.Write("Please enter a number to search for: ");
            int numberToSearch = int.Parse(Console.ReadLine());
            for (int i = 0; i < integerArray.Length; i++)
            {
                // 3.Loop through the array and compare the values with the input given by the user.
                if (integerArray[i] == numberToSearch)
                {
                    // 4.If the item is found, print out in which index the value was found.
                    Console.WriteLine($"Number { numberToSearch } was found in the index {i}.");
                }
            }
            // 5.Implement the same logic for the string array.
            Console.Write("Please enter a string to search for: ");
            string stringToSearch = Console.ReadLine(); // String -> No need to parse
            for (int i = 0; i < stringArray.Length; i++)
            {
                // 3.Loop through the array and compare the values with the input given by the user.
                if (stringArray[i].Equals(stringToSearch, StringComparison.InvariantCultureIgnoreCase)) // Let's ignore the case
                {
                    // 4.If the item is found, print out in which index the value was found.
                    Console.WriteLine($"String \"{ stringToSearch }\" was found in the index {i}.");
                }
            }
        }
    }
}
