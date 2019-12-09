using System;
using SalaryBreakdownCalculator.Exceptions;

namespace SalaryBreakdownCalculator
{
    class BudgetRepairLevy
    {
        private readonly Salary salary;
        private const int BudgetRepairLevyFirstBracketPercentage = 0;       //For Taxable Income range ($0 - $180,000)
        private const int BudgetRepairLevySecondBracketPercentage = 2;      //For Taxable Income range ($180,001 and over)

        //CONSTRUCTOR
        public BudgetRepairLevy(Salary salary)
        {
            this.salary = salary;
        }

        internal void CalculateBudgetRepairLevy()
        {
            try
            {
                // TI Round down to nearest dollar when calculating deductions
                double taxableIncome = Math.Floor(salary.TaxableIncome);

                if (taxableIncome > 0 && taxableIncome <= 180000)
                    salary.BudgetRepairLevy = Math.Ceiling(taxableIncome * BudgetRepairLevyFirstBracketPercentage / 100);                 // Budget Repair Levy - Always round up to the nearest dollar    
                else if (taxableIncome >= 180001)
                    salary.BudgetRepairLevy = Math.Ceiling((taxableIncome - 180000) * BudgetRepairLevySecondBracketPercentage / 100);     // Budget Repair Levy - Always round up to the nearest dollar
            }
            catch (Exception ex)
            {
                throw new CalculateBRLevyException("Class: BudgetRepairLevy, message: " + ex.Message);
            }
        }
    }
}
