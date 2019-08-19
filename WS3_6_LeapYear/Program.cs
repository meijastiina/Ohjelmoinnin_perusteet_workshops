using System;

namespace WS3_6_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks the user to enter a year and checks whether it is a leap year. 
            Console.Write("Please enter a year to be checked: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = false;
            // From the year 1753 we have been using Gregorian calendar in which leap years are:
            if (year % 4 == 0)  // 1.every year that is exactly divisible by four
            {
                if (year % 100 == 0)  // 1.except for years that are exactly divisible by 100
                {
                    if (year % 400 == 0)     // but these centurial years are leap years if they are exactly divisible by 400.
                    {
                        isLeapYear = true;
                    }
                } else
                {
                    isLeapYear = true;
                }
            }
            
            if (isLeapYear)
            {
                Console.WriteLine($"{ year } is a leap year.");
            } else
            {
                Console.WriteLine($"{ year } is NOT a leap year.");
            }
        }
    }
}
