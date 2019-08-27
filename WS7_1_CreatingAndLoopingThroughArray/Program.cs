using System;

namespace WS7_1_CreatingAndLoopingThroughArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program with the following arrays:
            // 1.an integer array with five items: 5, 7, 32, 31 and 8.
            int[] myIntegerArray = new int[5] { 5, 7, 32, 31, 8 };
            // 2.a double array with three items: 12.4, -13.55 and 67.44,
            double[] myDoubleArray = new double[3] { 12.4, -13.55, 67.44 };
            // 3.a string array with four items: “Helsinki”, “Lissabon”, “New York” and “Shanghai”.
            string[] myStringArray = new string[4] { "Helsinki", "Lissabon", "New York", "Shanghai" };
            // Then print out the following in your main method:
            // -   ”The value in the index number 3 is: “ and the value from the string array.
            Console.WriteLine("The value in the index number 3 is: " + myStringArray[3]);
            //-   -	“The fourth item in the int array is: “ and the value from the int array.
            Console.WriteLine("The fourth item in the int array is: " + myIntegerArray[3]);
            //    -   “In the double array there are xx items” where xx is the size of the array.
            Console.WriteLine($"In the double array there are { myDoubleArray.Length } items.");
            //    - The whole content of the integer array with a loop.
            for (int i = 0; i < myIntegerArray.Length; i++)
            {
                Console.WriteLine(myIntegerArray[i]);
            }
            //    - The whole content of the double integer from the last item to the first.
            for (int i = myDoubleArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(myDoubleArray[i]);
            }
            // Lastly, in a loop go through the string array and set all the values to be “empty”.
            for (int i = 0; i < myStringArray.Length; i++)
            {
                myStringArray[i] = "empty";
            }
        }
    }
}
