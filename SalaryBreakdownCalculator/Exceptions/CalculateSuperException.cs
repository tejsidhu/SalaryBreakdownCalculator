using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryBreakdownCalculator.Exceptions
{
    class CalculateSuperException : Exception
    {
        public CalculateSuperException()
        { }
        public CalculateSuperException(string message) : base(message)
        { }
        public CalculateSuperException(string message, Exception e) : base(message, e)
        { }
    }
}
