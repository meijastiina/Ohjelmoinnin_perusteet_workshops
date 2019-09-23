using System;
using System.Collections.Generic; // This is needed for Lists to work

namespace WS7_3_Linear_Search_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************************************************************
            * 
            * THIS IS THE SAME AS WS7_3_Linear_Search BUT INSTEAD OF ARRAY IT'S USING A GENERIC LIST
            * AND INSTEAD OF FOR IT'S USING FOREACH FOR SIMPLE LOOP
            * 
            * *******************************************************************************************************/
            // 1.	Create two arrays with the following items:
            // a.  55, 23, 6456, 324, 21, 234, 72, 21
            List<int> integerList = new List<int>();
            integerList.Add(55);
            integerList.Add(23);
            integerList.Add(6456);
            integerList.Add(324);
            integerList.Add(21);
            integerList.Add(234);
            integerList.Add(72);
            integerList.Add(21);

            // b., Kauko, Matti, Minna, Maisa, Juuso, Mauno
            List<string> stringList = new List<string>();
            stringList.Add("Petteri");
            stringList.Add("Kauko");
            stringList.Add("Matti");
            stringList.Add("Minna");
            stringList.Add("Maisa");
            stringList.Add("Juuso");
            stringList.Add("Mauno");

            // 2.Ask the user what they want to search for in the integer list.
            Console.Write("Please enter a number to search for: ");
            int numberToSearch = int.Parse(Console.ReadLine());
            for (int i = 0; i < integerList.Count; i++)
            {
                // 3.Loop through the list and compare the values with the input given by the user.
                if (integerList[i] == numberToSearch)
                {
                    // 4.If the item is found, print out in which index the value was found.
                    Console.WriteLine($"Number { numberToSearch } was found in the index {i}.");
                }
            }
            // 5.Implement the same logic for the string list.
            Console.Write("Please enter a string to search for: ");
            string stringToSearch = Console.ReadLine(); // String -> No need to parse
            for (int i = 0; i < stringList.Count; i++)
            {
                // 3.Loop through the array and compare the values with the input given by the user.
                if (stringList[i].Equals(stringToSearch, StringComparison.InvariantCultureIgnoreCase)) // Let's ignore the case
                {
                    // 4.If the item is found, print out in which index the value was found.
                    Console.WriteLine($"String \"{ stringToSearch }\" was found in the index {i}.");
                }
            }
        }
    }
}
