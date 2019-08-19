using System;

namespace WS3_4_Weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a program that asks the user for a weekday. 
            Console.Write("Enter a weekday: ");
            /* One way of handling case insensitivity is to use lowercase presentation of the string in the comparison. 
             * ToLower() changes all letters in the string to lower case. (ex. SuNdaY -> sunday).
             * Another way to handle this would be to make a case insensitive comparison:
             * if (weekday.Equals("sunday", StringComparison.InvariantCultureIgnoreCase))
             */
            string weekday = Console.ReadLine().ToLower(); 

            // 2.Program will tell whether the weekday is weekend day or not.
            if ( weekday.Equals("sunday") || weekday.Equals("saturday")) 
                /* As a programmer you want to be lazy -> choose the case with
                 * fewer options to be listed as if condition.
                 * It is also easier to read.
                 */
            {
                Console.WriteLine("It's weekend!");
            } else
            {
                Console.WriteLine("It's a weekday");
            }
        }
    }
}
