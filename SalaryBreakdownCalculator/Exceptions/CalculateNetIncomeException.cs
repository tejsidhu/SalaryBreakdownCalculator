using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
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
