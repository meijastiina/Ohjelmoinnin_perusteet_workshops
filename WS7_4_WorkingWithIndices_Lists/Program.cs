using System;
using System.Collections.Generic; // This is needed for Lists to work

namespace WS7_4_WorkingWithIndices_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>(); 
            int grade; // This is used for storing the input
            for (int i = 0; i < 21; i++) // Loops through the 21 students
            {
                Console.Write($"Grade for student { i + 1 }: ");
                grade = int.Parse(Console.ReadLine());
                grades[grade] = grades[grade] + 1; // Increments the number of this specific grade
            }
            // All the grades have been entered
            for (int i = 0; i < grades.Count; i++) // Loops through the grades 0-5
            {
                Console.Write($"{ i }:");
                for (int j = 0; j < grades[i]; j++) // Adds as many asterisks as the value in this index
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Next grade on a new line
            }
        }
    }
}
