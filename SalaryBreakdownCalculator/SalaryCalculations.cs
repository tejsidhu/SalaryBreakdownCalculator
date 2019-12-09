using System;

namespace SalaryBreakdownCalculator
{
    class SalaryCalculations : ISalaryCalculations
    {
        private readonly Salary salary;
        private readonly Validation validation;
        private readonly Superannuation super;
        private readonly TaxableIncome taxableIncome;
        private readonly MedicareLevy medicareLevy;
        private readonly BudgetRepairLevy budgetRepairLevy;
        private readonly IncomeTax incomeTax;
        private readonly NetIncome netIncome;
        private readonly PayPacket payPacket;


        //CONSTRUCTOR
        public SalaryCalculations()
        {
            salary = new Salary();
            validation = new Validation(salary);
            super = new Superannuation(salary);
            taxableIncome = new TaxableIncome(salary);
            medicareLevy = new MedicareLevy(salary);
            budgetRepairLevy = new BudgetRepairLevy(salary);
            incomeTax = new IncomeTax(salary);
            netIncome = new NetIncome(salary);
            payPacket = new PayPacket(salary);
        }

        internal void RunApp()
        {
            try
            {
                //Get Salary figures from User
                Console.Write("\nEnter your salary package amount: ");
                ReadAndValidateSalary();

                //Get Pay frequency from User
                Console.Write("\nEnter your pay frequency [W -- Weekly, F -- Fortnightly, M -- Monthly]: ");
                ReadAndValidateFrequency();

                Console.WriteLine("\n\nCalculating Salary Details... ");

                //Calculating salary breakdowns               
                CalculateSalary();

                //Print Salary breakdown on screen
                PrintSalaryBreakdowns();

                //Read for User input to exit
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception occured: " + e.Message);
                Console.ReadLine();
            }
        }

        // This Method prints the calculated salary details on screen.
        internal void PrintSalaryBreakdowns()
        {
            Console.WriteLine("\n\nGross Package: $" + salary.GrossPackage);
            Console.WriteLine("\nSuperannution: $" + salary.Superannution);
            Console.WriteLine("\n\nTaxable Income: $" + salary.TaxableIncome);
            Console.WriteLine("\n\nDeductions:");
            Console.WriteLine("\nMedicare Levy: $" + salary.MedicareLevy);
            Console.WriteLine("\nBudget Repair Levy: $" + salary.BudgetRepairLevy);
            Console.WriteLine("\nIncome Tax: $" + salary.IncomeTax);
            Console.WriteLine("\n\nNet Income: $" + salary.NetIncome);
            Console.WriteLine("\nPay Packet: $" + salary.PayPacket + " per " + salary.PayFrequency.ToString());
            Console.WriteLine("\n\nPress any key to end...");
        }

        internal void ReadAndValidateSalary()
        {
            bool loopFlag = true;

            //Read the figure from console until input is not correct
            while (loopFlag)
            {
                try
                {
                    //Get the Input from the console
                    var input = Console.ReadLine().Trim();

                    //Validate input
                    loopFlag = validation.ValidateSalary(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " \n\nEnter the salary again: ");
                    loopFlag = true;
                    continue;
                }
            }
        }


        internal void ReadAndValidateFrequency()
        {
            bool loopFlag = true;

            //Read the payment frequency from the console
            while (loopFlag)
            {
                try
                {
                    //Read input
                    var userInput = Console.ReadLine().Trim().ToUpper();

                    //Validate input
                    loopFlag = validation.ValidateFrequencyInput(userInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " \n\nEnter the frequency again: ");
                    loopFlag = true;
                    continue;
                }
            }
        }

        public void CalculateSalary()
        {
            try
            {
                //CALCUALTE SUPER = 9.5% OF GROSS
                super.CalculateSuperAmount();

                //CALCULATE TAXBALE INCOME
                taxableIncome.CalculateTaxableIncome();

                //MEDICARE LEVY
                medicareLevy.CalculateMedicareLevy();

                //BUDGET REPAIR LEVY
                budgetRepairLevy.CalculateBudgetRepairLevy();

                //INCOME TAX
                incomeTax.CalculateIncomeTax();

                //NET INCOME = GROSS INCOME - SUPER - DEDUCTIONS
                netIncome.CalculateNetIncome();

                //PAY PACKET = NET INCOME / PAY FREQUENCY
                payPacket.CalculatePayPacket();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nRuntime Exception occured, see attached details, \n" + ex.Message);
            }
        }
    }
}
