using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryBreakdownCalculator.Exceptions
{
    class CalculateMedicareLevyException : Exception
    {
        public CalculateMedicareLevyException()
        { }
        public CalculateMedicareLevyException(string message) : base(message)
        { }
        public CalculateMedicareLevyException(string message, Exception e) : base(message, e)
        { }
    }
}
