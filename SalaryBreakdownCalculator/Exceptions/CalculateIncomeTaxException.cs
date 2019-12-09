using System;


namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
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
