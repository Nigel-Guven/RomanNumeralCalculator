using System;

namespace RomanNumeralCalculator.Application.Extensions.Exceptions
{
    public class InvalidRomanNumeralInputException : Exception
    {
        public InvalidRomanNumeralInputException()
        {
        }

        public InvalidRomanNumeralInputException(string message)
            : base(message)
        {
        }

        public InvalidRomanNumeralInputException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
