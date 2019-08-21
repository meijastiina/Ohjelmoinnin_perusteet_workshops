using System;

namespace WS4_2_EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for an email address and validates it. 
            Console.Write("Please enter an email: ");
            string email = Console.ReadLine();
            /* Email is valid if it fulfils all the requirements listed below: 
             * - includes one @ sign
             * - includes one dot(.)
             * - is longer than 5 characters
             * (Of course this is not a fully functional email validation but good enough for now.)
             */
            if (email.Contains("@") && email.Contains(".") && email.Length > 5)
            {
                Console.WriteLine("Email ok!");
            } else
            {
                Console.WriteLine("Invalid email");
            }
        }
    }
}
