using System;

namespace WS7_2_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // -	Create a program that asks for grades for five assignments and stores them in an integer array. 
            int[] grades = new int[5];
            for (int i = 0; i < 5; i++) // Loops through the array from first to last item
            {
                // We have a +1 here because we start indexing from 0 but usually for humans we start from 1
                Console.Write($"Enter the grade for assignment { i + 1 }: "); 
                grades[i] = int.Parse(Console.ReadLine());
            }
            // -After the grades have been stored, the program prints them out ordered from the lowest to the highest and calculates the average and prints it out. 
            Array.Sort(grades); // This sorts the array
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
                sum += grades[i]; // Let's calculate the sum of grades to use in the average calculation.
            }
            Console.WriteLine($"Grade average is: { (double)sum / grades.Length }");
        }
    }
}
