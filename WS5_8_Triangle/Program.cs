using System;

namespace WS5_8_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that can print out a triangle. 
            //First the program asks for the size of the triangle
            Console.WriteLine("Size of triangle: ");
            int size = int.Parse(Console.ReadLine());
            // Size determines how many rows and columns at the bottom the triangle will have.
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
