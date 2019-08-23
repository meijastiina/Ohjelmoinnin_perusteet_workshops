
using System;

namespace WS5_1_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints out multiplication tables for 1-20. Use for loops. 
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Multiplication table for { i }:");
                Console.WriteLine("*************************");
                for (int j = 1; j <= 10; j++)
                {
                    // { j, 6 } means that we reserve 6 characters for number j and it's right aligned
                    // { " ", 5 } just creates five empty spaces
                    Console.WriteLine($"*{ j, 6 } * { i, 2 } = { i * j, 3 }{ " ", 5} *");
                }
                Console.WriteLine("*************************");
                Console.WriteLine();
            }
        }
    }
}
