using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
    public class InputSalaryException : Exception
    {
        public InputSalaryException() 
        {}
        public InputSalaryException(string message) : base(message)
        {}
        public InputSalaryException(string message, Exception e) : base(message, e)
        {}
    }
}
