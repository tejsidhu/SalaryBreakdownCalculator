using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
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
