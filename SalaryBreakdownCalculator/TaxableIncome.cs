using System;
using SalaryBreakdownCalculator.Exceptions;

namespace SalaryBreakdownCalculator
{
    public class TaxableIncome
    {
        private readonly Salary salary;

        //CONSTRUCTOR
        public TaxableIncome(Salary gross)
        {
            salary = gross;
        }

        public void CalculateTaxableIncome()
        {
            try
            {
                //Calculating Taxable Income
                salary.TaxableIncome = Math.Round(salary.GrossPackage - salary.Superannution, 2);
            }
            catch (Exception ex)
            {
                throw new CalculateTaxableIncomeException("Class: TaxableIncome, message: " + ex.Message);
            }
        }
    }
}
