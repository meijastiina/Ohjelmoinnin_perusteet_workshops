using System;

namespace WS7_5_SmallestAndLargestWithRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.	Create a program with a 100 item array that is initialized with random numbers of range 0-1000.
            int[] randomNumberArray = new int[100];
            // To create random numbers you can use Random class
            Random randomiser = new Random(); // Here we initialise an instance of the Random class
            for (int i = 0; i < randomNumberArray.Length; i++) // Loops through the array
            {
                randomNumberArray[i] = randomiser.Next(1000); // Creates a new random number
                Console.Write(randomNumberArray[i] + "\t"); // Prints out the random number
            }
            Console.WriteLine();
            // 2.	Find the largest value in the array using a loop and print it out. 
            int compareValue = randomNumberArray[0]; // Let's set the value first to be the value in the first index
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                if (compareValue < randomNumberArray[i])
                {
                    compareValue = randomNumberArray[i];
                }
            }
            Console.WriteLine($"The largest value is { compareValue }.");
            // 3.	Find the smallest value in the array using a loop and print it out. 
            compareValue = randomNumberArray[0]; // Let's set the value first to be the value in the first index
            for (int i = 1; i < randomNumberArray.Length; i++)
            {
                if (compareValue > randomNumberArray[i])
                {
                    compareValue = randomNumberArray[i];
                }
            }
            Console.WriteLine($"The smallest value is { compareValue }.");
        }
    }
}
