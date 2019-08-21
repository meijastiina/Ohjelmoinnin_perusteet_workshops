using System;

namespace WS4_3_PrintingAMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print out the menu shown below. 
            Console.WriteLine("*********************************");
            Console.WriteLine("*\t1 - Start a car\t\t*");
            Console.WriteLine("*\t2 - Drive a car\t\t*");
            Console.WriteLine("*\t3 - Turn car off\t*");
            Console.WriteLine("*\t4 - Quit game\t\t*");
            Console.WriteLine("*********************************");

            int choice = int.Parse(Console.ReadLine());

            // Use switch case to figure out user’s selection. Print something relevant for each selection. 
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Car started");
                    break;
                case 2:
                    Console.WriteLine("Car moving");
                    break;
                case 3:
                    Console.WriteLine("Car stopped");
                    break;
                case 4:
                    Console.WriteLine("Good bye!");
                    break;

            }
        }
    }
}
