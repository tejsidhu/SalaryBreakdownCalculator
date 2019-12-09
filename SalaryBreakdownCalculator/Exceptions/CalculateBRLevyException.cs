using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
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
