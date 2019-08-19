using System;

namespace WS3_3_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a program that asks for user’s age.
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            // 2.If the given age is greater than 17, print out: “You are of age.”,
            if (age > 17)
            {
                Console.WriteLine("You are of age.");
            }
            else // otherwise print out: “You’re a minor.”.
            {
                Console.WriteLine("You're a minor.");
            }
        }
    }
}
