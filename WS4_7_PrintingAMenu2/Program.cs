using System;

namespace WS4_7_PrintingAMenu2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string distance = "";
            do
            {
                // Print out the menu shown below. 
                Console.WriteLine("*********************************");
                Console.WriteLine("*\t1 - Start a car\t\t*");
                Console.WriteLine("*\t2 - Drive a car\t\t*");
                Console.WriteLine("*\t3 - Turn car off\t*");
                Console.WriteLine("*\t4 - Quit game\t\t*");
                Console.WriteLine("*********************************");

                choice = int.Parse(Console.ReadLine());

                // Use switch case to figure out user’s selection. Print something relevant for each selection. 
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("   __");
                        Console.WriteLine(" _ | =\\__");
                        Console.WriteLine("/ o____o_\\");
                        break;
                    case 2:
                        Console.WriteLine("Car moving");
                        distance += "\t";
                        
                        Console.Write(distance);
                        Console.WriteLine("   __");
                        Console.Write(distance);
                        Console.WriteLine(" _ | =\\__");
                        Console.Write(distance);
                        Console.WriteLine("/ o____o_\\");
                        break;
                    case 3:
                        Console.WriteLine("Car stopped");
                        distance = "";
                        break;
                    case 4:
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 4);
        }
    }
}
