using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryBreakdownCalculator.Exceptions
{
    class CalculateBRLevyException : Exception
    {
        public CalculateBRLevyException()
        { }
        public CalculateBRLevyException(string message) : base(message)
        { }
        public CalculateBRLevyException(string message, Exception e) : base(message, e)
        { }
    }
}
