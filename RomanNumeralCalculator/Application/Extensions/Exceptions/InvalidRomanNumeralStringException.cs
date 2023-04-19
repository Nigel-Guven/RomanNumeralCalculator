using System;

namespace RomanNumeralCalculator.Application.Extensions.Exceptions
{
    public class InvalidRomanNumeralStringException : Exception
    {
        public InvalidRomanNumeralStringException()
        {
        }

        public InvalidRomanNumeralStringException(string message)
            : base(message)
        {
        }

        public InvalidRomanNumeralStringException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
