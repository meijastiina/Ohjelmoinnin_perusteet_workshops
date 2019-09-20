using System;
using System.Collections.Generic; // This is needed for Lists to work

namespace WS7_2_Grades_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************************************************************
             * 
             * THIS IS THE SAME AS WS7_1_Grades BUT INSTEAD OF ARRAY IT'S USING A GENERIC LIST
             * AND INSTEAD OF FOR IT'S USING FOREACH FOR SIMPLE LOOP
             * 
             * *******************************************************************************************************/
            // -	Create a program that asks for grades for five assignments and stores them in an integer array. 
            List<int> grades = new List<int>();
            for (int i = 0; i < 5; i++) // Loops through the array from first to last item
            {
                // We have a +1 here because we start indexing from 0 but usually for humans we start from 1
                Console.Write($"Enter the grade for assignment { i + 1 }: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            // -After the grades have been stored, the program prints them out ordered from the lowest to the highest and calculates the average and prints it out. 
            grades.Sort(); // This sorts the list
            int sum = 0;
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
                sum += grade; // Let's calculate the sum of grades to use in the average calculation.
            }
            Console.WriteLine($"Grade average is: { (double)sum / grades.Count }");
        }
    }
}
