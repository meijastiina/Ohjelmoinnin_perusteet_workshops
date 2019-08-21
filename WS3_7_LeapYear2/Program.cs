using System;

namespace WS_7_LeapYear2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Improve the leap year program created in the previous exercise by adding functionality also to handle the years before Gregorian calendar (1753). 
            Console.Write("Please enter a year to be checked: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeapYear = false;
            if (year < 1753)
            {
                if (year % 4 == 0)  // 1.every year that is exactly divisible by four
                {
                    isLeapYear = true;
                }
            }
            else
            {
                // From the year 1753 we have been using Gregorian calendar in which leap years are:
                if (year % 4 == 0)  // 1.every year that is exactly divisible by four
                {
                    if (year % 100 == 0)  // 1.except for years that are exactly divisible by 100
                    {
                        if (year % 400 == 0)     // but these centurial years are leap years if they are exactly divisible by 400.
                        {
                            isLeapYear = true;
                        }
                    }
                    else
                    {
                        isLeapYear = true;
                    }
                }
            }
            if (isLeapYear)
            {
                Console.WriteLine($"{ year } is a leap year.");
            }
            else
            {
                Console.WriteLine($"{ year } is NOT a leap year.");
            }
        }
    }
}
