using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryBreakdownCalculator.Exceptions
{
    class CalculateIncomeTaxException : Exception
    {
        public CalculateIncomeTaxException()
        { }
        public CalculateIncomeTaxException(string message) : base(message)
        { }
        public CalculateIncomeTaxException(string message, Exception e) : base(message, e)
        { }
    }
}
