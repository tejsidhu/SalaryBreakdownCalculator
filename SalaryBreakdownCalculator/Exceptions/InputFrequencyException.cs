using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    public class InputFrequencyException:Exception
    {
        public InputFrequencyException()
        { }
        public InputFrequencyException(string message) : base(message)
        { }
        public InputFrequencyException(string message, Exception e) : base(message, e)
        { }
    }
}
