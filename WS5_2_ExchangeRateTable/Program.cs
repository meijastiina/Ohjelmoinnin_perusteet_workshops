using System;
using System.Text;

namespace WS5_2_ExchangeRateTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints out a table with 1-10 euros and corresponding values in the old Finnish mark. 
            // You can use the exchange rate 1 € = 5.94573 Finnish Marks. 
            double exchangeRate = 5.94573;
            // If the euro sign doesn't show up properly, you might need to change the encoding.
            Console.OutputEncoding = Encoding.UTF8; 
            for (int i = 1; i <= 10; i++)
            {
                // Math.Round( i * exchangeRate, 2 ) rounds the result in two decimals 
                // and , 5 } reserves 5 characters for the number and aligns right.
                Console.WriteLine($"{ i, 3 } € = { Math.Round( i * exchangeRate, 2 ), 5 }");
            }
        }
    }
}
