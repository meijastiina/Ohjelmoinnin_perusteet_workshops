using System;

namespace WS7_4_WorkingWithIndices
{
    /* 
     * Create a program that asks for grades (on the scale 0-5) for 21 students and counts the number of each grade. 
     * After the grades have been entered the program prints out how many of each grades were given using asterisks. 
     * In this exercise you’re only interested in the number of each grade (How many fives there were etc), 
     * no need to store the data on specific student’s grade. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[6]; // Scale 0-5 -> We need 6 items
            int grade; // This is used for storing the input
            for (int i = 0; i < 21; i++) // Loops through the 21 students
            {
                Console.Write($"Grade for student { i + 1 }: ");
                grade = int.Parse(Console.ReadLine());
                grades[grade] = grades[grade]+1; // Increments the number of this specific grade
            }
            // All the grades have been entered
            for (int i = 0; i < grades.Length; i++) // Loops through the grades 0-5
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
