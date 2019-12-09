using SalaryBreakdownCalculator.Exceptions;
using System;


namespace SalaryBreakdownCalculator
{
    //CLASS CALCULATING SUPER AMOUNT
    public class Superannuation
    {
        private readonly Salary salary;

        //CONSTRUCTOR
        public Superannuation(Salary gross)
        {
            salary = gross;
        }

        public double SUPERCONTRIBUTION { get; set; } = 9.5;

        public void CalculateSuperAmount()
        {
            try
            {
                //Superannution = ( Gross Salary * super contribution ) / 100
                double superAmount = salary.GrossPackage * SUPERCONTRIBUTION / 100;

                superAmount = Math.Round(superAmount, 2, MidpointRounding.AwayFromZero); //Rounded up to the nearest cent

                salary.Superannution = superAmount;
            }
            catch (Exception ex)
            {
                throw new CalculateSuperException("Class: Superannuation, message: " + ex.Message);
            }
        }
    }
}
