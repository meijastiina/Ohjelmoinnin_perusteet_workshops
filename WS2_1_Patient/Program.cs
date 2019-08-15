using System;

namespace WS2_1_Patient
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a program that has two variables; patientFirstName and patientLastName.
            // 2. Set the values for those variables to be Matti and Meikäläinen.
            var patientFirstName = "Matti"; // This variable is a string
            string patientLastName; // At this point this variable doesn't have a value
            patientLastName = "Meikäläinen"; // Value can be assigned at a later stage, too
            // 3. Print out the patient’s name on one line, separated by a space. 
            Console.WriteLine(patientFirstName + " " + patientLastName); // This is the traditional way concatenating strings
            Console.WriteLine($"{ patientFirstName } { patientLastName}"); // In C# you can also use values of variables in a string this way (will give the same result as above).
        }
    }
}
