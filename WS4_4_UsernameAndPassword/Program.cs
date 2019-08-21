using System;

namespace WS4_4_UsernameAndPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that first asks user for username and password. Store the values in string variables username and password.
            Console.WriteLine("****\tREGISTER\t***");
            Console.Write("Username: ");
            string registeredUsername = Console.ReadLine();
            Console.Write("Password: ");
            string registeredPassword = Console.ReadLine();
            bool loggedIn = false; // A flag to determine whether user is logged in or not.
            // Program keeps asking till the correct values are entered. 
            // Use do while or while loop to implement this.
            do
            {
                // Then the program will simulate log in and asks for username and password for loggin in. 
                Console.WriteLine("\n\n****\tLOG IN\t***");
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                // If the user enters correct values print out “Logged in” and the entered username and password.
                if (username.Equals(registeredUsername) && password.Equals(registeredPassword))
                {
                    loggedIn = true; // Login succesfull -| Set the flag to true
                    Console.WriteLine($"Logged in (username: { username }, password { password })");
                }
                else
                {
                    // If the values don’t match program will print out an error message.
                    Console.WriteLine("Incorrect username/password.");
                }
            } while (!loggedIn); // Keep asking till the correct credentials are entered.            
        }
    }
}
