using System;

namespace WS3_5_MorningChores
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a program that asks if the user has completed specific morning chores (breakfast, teeth brushing, packing). 
            Console.Write("Breakfast has been eaten: ");

            // 2.Use Boolean values to store given answers.
            bool breakfastEaten = bool.Parse(Console.ReadLine());
            Console.Write("Teeth have been brushed: ");
            bool teethBrushed = bool.Parse(Console.ReadLine());
            Console.Write("Backpack has been packed: ");
            bool backpackBacked = bool.Parse(Console.ReadLine());

            // 3.	Based on the answers given the program decides whether the user is ready to go to school or not.
            if (breakfastEaten && teethBrushed && backpackBacked) 
            /* You can use logical operator AND (&&) here to  make sure all the conditions are fullfilled.
             * You could also build the condition using logical operator OR (||):
             * if (breakfastEaten == false || teethBrushed == false || backpackBacked == false)
             * or
             * if (!breakfastEaten || !teethBrushed || !backpackBacked )
             */
            {
                Console.WriteLine("Off to school you go!");
            } else
            {
                Console.WriteLine("Hold your horses, something's missing!");
            }
        }
    }
}
