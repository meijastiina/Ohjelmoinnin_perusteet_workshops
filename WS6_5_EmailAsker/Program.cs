using System;

namespace WS6_5_EmailAsker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that calls a method AskEmail() and prints out the return value.
            Console.WriteLine("Email entered: " + AskEmail());
        }
        private static string AskEmail()
        {
            //  Implement AskEmail() method to ask user for an email address and returns the given value. 
            string email = "";
            // The method will keep asking for an email till a string that contains a @ is entered.
            do // We can use do here since we always want to ask at least once.
            {
                Console.WriteLine("Please enter email: ");
                email = Console.ReadLine();
            } while (!email.Contains("@")); // Let's loop for as long as the input doesn't contain @.
            return email;
        }
    }
}
