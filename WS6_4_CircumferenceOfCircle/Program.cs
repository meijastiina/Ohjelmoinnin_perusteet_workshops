using System;

namespace WS6_4_CircumferenceOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call this method three times with different parameters.
            Console.WriteLine("Circumference of a circle when radius is 1: " + CircumferenceOfACircle(1));
            Console.WriteLine("Circumference of a circle when radius is 1.567: " + CircumferenceOfACircle(1.567));
            Console.WriteLine("Circumference of a circle when radius is 1567: " + CircumferenceOfACircle(1567));
        }
        // Create a program that calculates the circumference of a circle when radius is given(circumference = 2 * π * radius). 
        private static double CircumferenceOfACircle(double radius)
        {
            return 2 * Math.PI * radius; // You can use Math class to get the value of π.
        }
    }
}
