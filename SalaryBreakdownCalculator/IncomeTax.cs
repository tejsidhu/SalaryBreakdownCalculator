using System;
using SalaryBreakdownCalculator.Exceptions;

namespace SalaryBreakdownCalculator
{
    class IncomeTax
    {
        private readonly Salary salary;
        public double IncomeTaxFirstBracketPercentage { get; set; }     = 0;           // For Taxable Income range ($0 - $18,200)
        public double IncomeTaxSecondBracketPercentage { get; set; }    = 19;          // For Taxable Income range ($18,201 - $37,000)
        public double IncomeTaxThirdBracketPercentage { get; set; }     = 32.5;        // For Taxable Income range ($37,001 - $87,000)
        public double IncomeTaxThirdBracketBaseRate { get; set; }       = 3572;        // $3,572 + 32.5% of the excess over $37,000
        public double IncomeTaxFourthBracketPercentage { get; set; }    = 37;          // For Taxable Income range ($87,001 - $180,000)
        public double IncomeTaxFourthBracketBaseRate { get; set; }      = 19822;       // $19,822 + 37% of the excess over $87,000
        public double IncomeTaxFifthBracketPercentage { get; set; }     = 47;          // For Taxable Income range ($180,001 - Over)
        public double IncomeTaxFifthBracketBaseRate { get; set; }       = 54232;       // $54,232 + 47% of the excess over $180,000

        //CONSTRUCTOR
        public IncomeTax(Salary salary)
        {
            this.salary = salary;
        }

        internal void CalculateIncomeTax()
        {
            try
            {
                // TI Round down to nearest dollar when calculating deductions
                double taxableIncome = Math.Floor(salary.TaxableIncome);

                if (taxableIncome > 0 && taxableIncome <= 18200)
                {
                    salary.IncomeTax = Math.Ceiling(taxableIncome * IncomeTaxFirstBracketPercentage / 100);                                             // Income Tax - Always round up to the nearest dollar    
                }
                else if (taxableIncome >= 18201 && taxableIncome <= 37000)
                {
                    salary.IncomeTax = Math.Ceiling((taxableIncome - 18200) * IncomeTaxSecondBracketPercentage / 100);                                  // Income Tax - Always round up to the nearest dollar    
                }
                else if (taxableIncome >= 37001 && taxableIncome <= 87000)
                {
                    salary.IncomeTax = Math.Ceiling(IncomeTaxThirdBracketBaseRate + (taxableIncome - 37000) * IncomeTaxThirdBracketPercentage / 100);   // Income Tax - Always round up to the nearest dollar    
                }
                else if (taxableIncome >= 87001 && taxableIncome <= 180000)
                {
                    salary.IncomeTax = Math.Ceiling(IncomeTaxFourthBracketBaseRate + (taxableIncome - 87000) * IncomeTaxFourthBracketPercentage / 100); // Income Tax - Always round up to the nearest dollar    
                }
                else if (taxableIncome >= 180001)
                {
                    salary.IncomeTax = Math.Ceiling(IncomeTaxFifthBracketBaseRate + (taxableIncome - 180000) * IncomeTaxFifthBracketPercentage / 100);  // Income Tax - Always round up to the nearest dollar    
                }
            }
            catch (Exception ex)
            {
                throw new CalculateIncomeTaxException("Class: IncomeTax, message: " + ex.Message);
            }
        }
    }
}
