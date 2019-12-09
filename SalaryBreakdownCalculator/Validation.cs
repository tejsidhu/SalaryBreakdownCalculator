using System;
using System.Linq;
using SalaryBreakdownCalculator.Exceptions;

namespace SalaryBreakdownCalculator
{
    public class Validation
    {
        private readonly Salary salary;
        private const int Zero = 0;        
        private const string WrongInput = "\nWrong Input. \nPlease choose W for Weekly, F for Fortnightly or M for Monthly option. Re-enter:";

        //CONSTRUCTOR
        public Validation(Salary salaryInfo)
        {
            salary = salaryInfo;
        }

        public bool ValidateSalary(string data)
        {
            bool repeatInput = true;
            var input = data;

            try
            {
                if (double.TryParse(input, out double grossPackage))
                {
                    if (grossPackage == Zero)
                        Console.Write("\nSalary package amount can't be 0.\nPlease re-enter amount: ");
                    else if (Double.IsInfinity(grossPackage) || Double.IsNaN(grossPackage))
                        Console.Write("\nInput Salary package can't be entertained.\nPlease re-enter amount: ");
                    else if (grossPackage > Zero)
                    {
                        repeatInput = false;
                        salary.GrossPackage = grossPackage;
                    }
                    else
                        Console.Write("\nSalary package can't be negetive value.\nPlease re-enter amount: ");
                }
                else if (input.All(c => char.IsWhiteSpace(c)))
                    Console.Write("\nSpace recorded.\nPlease enter a valid input for Salary package amount: ");
                else if (input.All(c => char.IsLetter(c)))
                    Console.Write("\nAlphabets recorded.\nPlease enter a numeric Salary package amount: ");
                else
                    Console.Write("\nUnrecognized input recorded.\nPlease re-enter the Salary package amount: ");

                return repeatInput;
            }
            catch (Exception e)
            {
                throw new InputSalaryException("\nException occured during Salary validation, see attached details: " + e.Message, e);
            }
        }

        internal bool ValidateFrequencyInput(string userInput)
        {
            bool repeatInput = true;

            try
            {
                if (userInput.Length > 1 || userInput.Length < 1)
                    Console.Write(WrongInput);
                else
                {
                    var input = Convert.ToChar(userInput);

                    if (char.IsLetterOrDigit(input))
                    {
                        if (char.IsLetter(input))
                        {
                            if (input == Convert.ToChar(Frequency.PaymentFrequency.Week))
                            {
                                salary.PayFrequency = Frequency.PaymentFrequency.Week;
                                repeatInput = false;
                            }
                            else if (input == Convert.ToChar(Frequency.PaymentFrequency.Fortnight))
                            {
                                salary.PayFrequency = Frequency.PaymentFrequency.Fortnight;
                                repeatInput = false;
                            }
                            else if (input == Convert.ToChar(Frequency.PaymentFrequency.Month))
                            {
                                salary.PayFrequency = Frequency.PaymentFrequency.Month;
                                repeatInput = false;
                            }
                            else
                                Console.Write(WrongInput);
                        }
                        else
                        {
                            Console.Write("\nPay Frequency option can't be Numeric data. \nPlease choose from W, F or M options. Re-enter: ");
                        }
                    }
                    else
                    {
                        Console.Write("\nPay Frequency option can't be special characters. \nRe-enter please: ");
                    }
                }
                return repeatInput;
            }
            catch (Exception e)
            {
                throw new InputFrequencyException("\nException occured during Pay frequency validation, see attached details: " + e.Message, e);
            }
        }
    }
}
