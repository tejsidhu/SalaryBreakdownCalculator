using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryBreakdownCalculator.Exceptions
{
    class CalculatePayPacketException : Exception
    {
        public CalculatePayPacketException()
        { }
        public CalculatePayPacketException(string message) : base(message)
        { }
        public CalculatePayPacketException(string message, Exception e) : base(message, e)
        { }
    }
}
