using System;

namespace WS6_3_SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call this method in your main method, save the return value in a variable and print out. Do this three times with different variable values. 
            int sum = Sum(1, 3);
            Console.WriteLine("1 + 3 = " + sum);
            Console.WriteLine("510 + 245 = " + Sum(510, 245));
            Console.WriteLine("89 + -12 = " + Sum(89, -12));
        }
        // Create a program that has a method Sum(int firstNumber, int secondNumber) that returns the sum of the numbers passed to the method as input parameters. 
        private static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
