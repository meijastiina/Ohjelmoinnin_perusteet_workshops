using System;

namespace WS5_3_CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a program that asks the user for a string and a character.
            Console.Write("Enter a string: ");
            string hayStack = Console.ReadLine();
            int counter = 0;
            int numberOfOccurences = 0;
            Console.Write("Enter a character to search: ");
            char needle = char.Parse(Console.ReadLine());
            // 2.Use method indexOf() to search for the given character in the given string.You can check out the method in the C# documentation in https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof?view=netframework-4.8 .
            counter = hayStack.IndexOf(needle, counter); // Let's find the first occurence
            while ( counter != -1 ) // Let's loop for as long as there are occurences found
            {
                numberOfOccurences++; // Increase the number of found occurences
                counter++; // Increase the counter in order to start the next search from the next character
                counter = hayStack.IndexOf(needle, counter);
            }
            Console.WriteLine($"We found { numberOfOccurences } occurences of { needle } in the string { hayStack }");

        }
    }
}
