using System;

namespace SalaryBreakdownCalculator.Exceptions
{
    [Serializable]
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
