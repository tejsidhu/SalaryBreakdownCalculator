using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
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
