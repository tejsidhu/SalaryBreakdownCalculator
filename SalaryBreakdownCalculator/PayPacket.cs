using SalaryBreakdownCalculator.Exceptions;
using System;

namespace SalaryBreakdownCalculator
{
    class PayPacket
    {
        private readonly Salary salary;
        private const double WeeksInYear        = 52;
        private const double FortnightsInYear   = 26;
        private const double MonthsInYear       = 12;

        //CONSTRUCTOR
        public PayPacket(Salary salary)
        {
            this.salary = salary;
        }

        internal void CalculatePayPacket()
        {
            try
            {
                // Pay Packet is Net Income for the specified pay frequency i.e. Weekly, Fortnightly or Monthly
                if (salary.PayFrequency == Frequency.PaymentFrequency.Week)
                    salary.PayPacket = Math.Round(salary.NetIncome / WeeksInYear, 2);
                else if (salary.PayFrequency == Frequency.PaymentFrequency.Fortnight)
                    salary.PayPacket = Math.Round(salary.NetIncome / FortnightsInYear, 2);
                else if (salary.PayFrequency == Frequency.PaymentFrequency.Month)
                    salary.PayPacket = Math.Round(salary.NetIncome / MonthsInYear, 2);
            }
            catch (Exception ex)
            {
                throw new CalculatePayPacketException("Class: PayPacket, message: " + ex.Message);
            }
        }
    }
}
