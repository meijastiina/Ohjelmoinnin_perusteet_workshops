using System;

namespace WS5_4_LeapYearTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints out a list of leap years (1753-2050). You can have a look at the leap year calculation from the previous workshops. 
            for (int year = 1753; year <= 2050; year++)
            {
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
                if ( isLeapYear )
                {
                    Console.WriteLine($"Year { year } is a leap year");
                }
            }
        }
    }
}
