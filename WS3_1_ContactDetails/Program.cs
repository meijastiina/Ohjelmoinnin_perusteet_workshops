using System;

namespace WS3_1_ContactDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a program that asks the user to enter their personal details: first names, last name, phone number, email address, birth year. Save entered values in variables.
            Console.WriteLine("Please enter your contact details");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();
            Console.Write("Enter your birth year: ");
            string birthYear = Console.ReadLine();

            Console.WriteLine("Thank you!");

            // 2. Print out personal details as shown below:
            Console.WriteLine("CONTACT DETAILS");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Nimi: ");
            Console.WriteLine($"\t{ lastName }, { firstName }");
            Console.WriteLine("Puh: ");
            Console.WriteLine("\t" + phoneNumber);
            Console.WriteLine("Email: ");
            Console.WriteLine("\t" + email);
            Console.WriteLine("Age: ");
            int birthYearInt = int.Parse(birthYear); // To be able to calculate age using birth year we need to parse the string given by the user. In this example we can assume that the user enters valid information and we don't implement any exception handling. You can try and see what happens if you enter some text that can't be parsed as integer.
            Console.WriteLine("\t" + (DateTime.Now.Year - birthYearInt));
        }
    }
}
