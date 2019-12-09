using System;
using SalaryBreakdownCalculator.Exceptions;


namespace SalaryBreakdownCalculator
{
    class MedicareLevy
    {
        private readonly Salary salary;
        public int MedicareLevyFirstBracketPercentage { get; set; }     = 0;       //For Taxable Income range ($0 - $21,335)
        public int MedicareLevySecondBracketPercentage { get; set; }    = 10;     //For Taxable Income range ($21,336 - $26,668)
        public int MedicareLevyThirdBracketPercentage { get; set; }     = 2;       //For Taxable Income range ($26,669 - Over)

        //CONSTRUCTOR
        public MedicareLevy(Salary salary)
        {
            this.salary = salary;
        }

        internal void CalculateMedicareLevy()
        {
            try
            {
                // TI Round down to nearest dollar when calculating deductions
                double taxableIncome = Math.Floor(salary.TaxableIncome);

                if (taxableIncome > 0 && taxableIncome <= 21335)
                    salary.MedicareLevy = Math.Ceiling(taxableIncome * MedicareLevyFirstBracketPercentage / 100);               // Medicare Levy - Always round up to the nearest dollar
                else if (taxableIncome >= 21336 && taxableIncome <= 26668)
                    salary.MedicareLevy = Math.Ceiling((taxableIncome - 21335) * MedicareLevySecondBracketPercentage / 100);    // Medicare Levy - Always round up to the nearest dollar
                else if (taxableIncome >= 26669)
                    salary.MedicareLevy = Math.Ceiling(taxableIncome * MedicareLevyThirdBracketPercentage / 100);               // Medicare Levy - Always round up to the nearest dollar
            }
            catch (Exception ex)
            {
                throw new CalculateMedicareLevyException("Class: MedicareLevy, message: " + ex.Message);
            }
        }
    }
}
