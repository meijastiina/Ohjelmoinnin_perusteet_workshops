using System;

namespace WS4_6_PinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks the user for PIN code. Keep asking till the correct code(3120) is entered.Use do while or while loop.
            int pincode = 3120;
            int enteredPin;
            do // Do is a good choice here cause we always want to ask at least once.
            {
                Console.Write("PIN: ");
                enteredPin = int.Parse(Console.ReadLine());
            } while (enteredPin != pincode);
            Console.WriteLine("PIN ok!");
        }
    }
}
