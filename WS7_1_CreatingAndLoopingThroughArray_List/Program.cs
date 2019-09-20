using System;
using System.Collections.Generic; // This is needed for Lists to work

namespace WS7_1_CreatingAndLoopingThroughArray_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************************************************************
             * 
             * THIS IS THE SAME AS WS7_1_CreatingAndLoopingThroughArray BUT INSTEAD OF ARRAY IT'S USING A GENERIC LIST
             * AND INSTEAD OF FOR IT'S USING FOREACH FOR SIMPLE LOOP
             * 
             * *******************************************************************************************************/

            // Create a program with the following arrays:
            // 1.an integer list with five items: 5, 7, 32, 31 and 8.
            List<int> myIntegerList = new List<int>();
            myIntegerList.Add(5);
            myIntegerList.Add(7);
            myIntegerList.Add(32);
            myIntegerList.Add(31);
            myIntegerList.Add(8);

            // 2.a double list with three items: 12.4, -13.55 and 67.44,
            List<double> myDoubleList = new List<double>();
            myDoubleList.Add(12.4);
            myDoubleList.Add(-13.55);
            myDoubleList.Add(67.44);

            // 3.a string list with four items: “Helsinki”, “Lissabon”, “New York” and “Shanghai”.
            List<string> myStringList = new List<string>();
            myStringList.Add("Helsinki");
            myStringList.Add("Lissabon");
            myStringList.Add("New York");
            myStringList.Add("Shanghai");

            // Then print out the following in your main method:
            // -   ”The value in the index number 3 is: “ and the value from the string array.
            Console.WriteLine("The value in the index number 3 is: " + myStringList[3]);
            //-   -	“The fourth item in the int array is: “ and the value from the int array.
            Console.WriteLine("The fourth item in the int array is: " + myIntegerList[3]);
            //    -   “In the double array there are xx items” where xx is the size of the array.
            Console.WriteLine($"In the double array there are { myDoubleList.Count } items.");
            //    - The whole content of the integer array with a loop.
            foreach (int number in myIntegerList)
            {
                Console.WriteLine(number);
            }
            //    - The whole content of the double integer from the last item to the first.
            for (int i = myDoubleList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(myDoubleList[i]);
            }
            // Lastly, in a loop go through the string array and set all the values to be “empty”.
            for (int i = 0; i < myStringList.Count; i++)
            {
                myStringList[i] = "empty";
            }
        }
    }
}
