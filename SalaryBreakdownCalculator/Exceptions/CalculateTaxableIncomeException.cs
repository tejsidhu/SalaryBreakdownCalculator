using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
    class CalculateTaxableIncomeException : Exception
    {
        public CalculateTaxableIncomeException()
        { }
        public CalculateTaxableIncomeException(string message) : base(message)
        { }
        public CalculateTaxableIncomeException(string message, Exception e) : base(message, e)
        { }
    }
}
