using System;

namespace WS4_1_NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for user’s age. Implement conditionals (if, else if, else) that works as follows:
            Console.Write("Please give me your age: ");
            int age = int.Parse(Console.ReadLine());

            // If age is less than 0 or greater than 150 print “Invalid age!”
            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            // If age is less than 6 print ”Preschooler”
            else if ( age < 6) {
                Console.WriteLine("Preschooler");
            }
            // If age is 6 - 14 print ”You’re a child”
            else if (age < 15)
            {
                Console.WriteLine("You're a child");
                // If age is 14 print ”Challenging age”
                if (age == 14)
                {
                    Console.WriteLine("Challenging age");
                }
            }
            // If age is 16 - 18 print ”Almost grown up”
            else if (age <= 18)
            {
                Console.WriteLine("Almost grown up");
            }
            //If age is greater than 18 but less than 30 print ”You are an adult but not experiencing midlife crisis yet” 
            else if (age < 30)
            {
                Console.WriteLine("You are an adult but not experiencing midlife crisis yet");
            }
            // If age is greater or equal to 30 but less than 45 print ”You are middle aged”
            else if (age >= 30 && age < 45)
            {
                Console.WriteLine("You are middle aged");
            }
            // If age is greater than 45 but under 65 print ”You still have time before retirement!”
            else if (age > 45 && age < 65)
            {
                Console.WriteLine("You still have time before retirement!");
            }
            // Otherwise print “You’re a pensioner”
            else
            {
                Console.WriteLine("You’re a pensioner");
            }
        }
    }
}
