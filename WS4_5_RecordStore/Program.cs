using System;

namespace WS4_5_RecordStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that buys records for as long as there is money in the wallet. 
            // One record costs 20€. 
            // For each purchase, print out how much money is left.
            Console.Write("How much money have you got? ");
            double money = double.Parse(Console.ReadLine());
            int counter = 0; // A counter variable to keep count of how many records were purchased.
            while (money >= 20) // While is a good choice here in case we don't have enough money to begin with.
            {
                money -= 20; // One record costs 20€ -> deduct the amount of money left.
                counter++; // Increase the counter.
                Console.WriteLine($"Purchase number { counter }. Money left: { money }.");
            }
        }
    }
}
