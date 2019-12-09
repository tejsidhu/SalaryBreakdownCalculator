using System;

namespace SalaryBreakdownCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nSALARY BREAKDOWN PROGRAM.\n");

            //Initantiate the Salary Calculations object
            var salaryCalculations = new SalaryCalculations();

            //Run the application
            salaryCalculations.RunApp();
        }
    }
}

