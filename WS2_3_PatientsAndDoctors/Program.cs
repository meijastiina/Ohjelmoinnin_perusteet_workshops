using System;

namespace WS2_3_PatientsAndDoctors
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a program with two integer variables: numberOfPatients (21) and numberOfDoctors(6).
            int numberOfPatients = 21;
            int numberOfDoctors = 6;
            // 2. Print out on the screen the number of people in the hospital when there are only patients and doctors.
            Console.WriteLine($"There are { numberOfDoctors + numberOfPatients } people in the hospital ({ numberOfPatients } patients and { numberOfDoctors } doctors).");
            // 3. A new patient comes into the hospital. Increment the number of patients respectively and print out the new number of patients on the screen.
            Console.WriteLine($"*** A new patient comes in ****");
            numberOfPatients++; // Let's increment the number of patients by one
            // You could also do numberOfPatients = numberOfPatients + 1; or numberOfPatients += 1;
            Console.WriteLine($"There are { numberOfPatients } patients in the hospital.");
            // 4. Three doctors go home.Update the value of the variable and print out the new state of things.
            Console.WriteLine($"*** Three doctors go home ****");
            numberOfDoctors -= 3;
            Console.WriteLine($"There are { numberOfDoctors } doctors in the hospital.");
            // 5. Create a new variable and calculate the average number of patients per doctor.Print out the info.
            double numberOfPatientsPerDoctor = (double)numberOfPatients / numberOfDoctors;
            // Since numberOfPatients and numberOfDoctors are both integers the result will be an integer -> if you want decimals in your result you need to do a type cast with (double)
            Console.WriteLine($"Average number of patients per doctor is { numberOfPatientsPerDoctor }.");
            // 6. Calculate how many patients can be handled if each patient needs exactly three forms and there are eight forms left. Print out.
            int numberOfForms = 8;
            int numberOfFormsPerPatient = 3;
            Console.WriteLine($"There are { numberOfForms } forms left. Each patient needs { numberOfFormsPerPatient } forms. { numberOfForms / numberOfFormsPerPatient } patients can still be attended to.");
            // 7. Print out how many forms are left.
            Console.WriteLine($"{ numberOfForms % numberOfFormsPerPatient } forms will be left.");
        }
    }
}
