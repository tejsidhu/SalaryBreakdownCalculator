using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryBreakdownCalculator.Exceptions
{
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
