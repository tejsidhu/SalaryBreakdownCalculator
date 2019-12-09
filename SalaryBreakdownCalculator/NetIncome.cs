using System;
using SalaryBreakdownCalculator.Exceptions;


namespace SalaryBreakdownCalculator
{
    class NetIncome
    {
        private readonly Salary salary;

        //CONSTRUCTOR
        public NetIncome(Salary salary)
        {
            this.salary = salary;
        }

        internal void CalculateNetIncome()
        {
            try
            {
                //Net Income = Gross Package - Super - Deductions (Medicare Levy, Budget Repair Levy, Income Tax)
                salary.NetIncome = Math.Round(salary.GrossPackage - salary.Superannution - (salary.MedicareLevy + salary.BudgetRepairLevy + salary.IncomeTax), 2);
            }
            catch (Exception ex)
            {
                throw new CalculateNetIncomeException("Class: NetIncome, message: " + ex.Message);
            }
        }
    }
}
