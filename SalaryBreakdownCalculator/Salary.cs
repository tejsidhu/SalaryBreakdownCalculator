
namespace SalaryBreakdownCalculator
{
    public class Salary
    {
        public Salary()
        { }

        //Property to find out the Salary Type i.e. Gross, Hourly or Commision based, 
        //Can be used for future extensions
        public string SalaryType { get; set; }

        //GET or SET: GROSS SALARY PACKAGE
        public double GrossPackage { get; set; }

        //GET or SET: Pay Frequency
        public Frequency.PaymentFrequency PayFrequency { get; set; }

        //GET or SET: Superannution
        public double Superannution { get; set; }

        //GET or SET: Taxable Income
        public double TaxableIncome { get; set; }
        
        //GET or SET: Medicare Levy
        public double MedicareLevy { get; set; }

        //GET or SET: Budget Repair Levy
        public double BudgetRepairLevy { get; set; }
        
        //GET or SET: Income Tax
        public double IncomeTax { get; set; }

        //GET or SET: Net Income
        public double NetIncome { get; set; }

        //GET or SET: Pay Packet
        public double PayPacket { get; set; }
    }
}