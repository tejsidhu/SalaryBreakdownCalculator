using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryBreakdownCalculator.Exceptions
{
    class CalculateNetIncomeException : Exception
    {
        public CalculateNetIncomeException()
        { }
        public CalculateNetIncomeException(string message) : base(message)
        { }
        public CalculateNetIncomeException(string message, Exception e) : base(message, e)
        { }
    }
}
