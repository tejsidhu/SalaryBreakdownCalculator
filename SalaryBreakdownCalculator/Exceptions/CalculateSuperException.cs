using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
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
