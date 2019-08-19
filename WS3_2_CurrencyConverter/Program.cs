using System;

namespace WS3_2_CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create a program that asks the user for the convert rate for US dollars and the amount to be converted in euros.
            Console.WriteLine("****************************************");
            Console.WriteLine("*          CURRENCY CONVERTER          *");
            Console.WriteLine("****************************************");
            Console.Write("Please enter currency convert rate: ");
            var rate = Console.ReadLine();
            Console.Write("Please enter amount in euros: ");
            var amount =  Console.ReadLine();
            // 2.Calculate the amount of US dollars that equal the amount given in euros.
            var convertedAmount = double.Parse(amount) / double.Parse(rate); // Console.ReadLine(); returns a string. We can't use strings in calculations -> we must parse the string into a double.
            Console.WriteLine($"Amount in dollars: { convertedAmount } ");
            Console.WriteLine("****************************************");
        }
    }
}
