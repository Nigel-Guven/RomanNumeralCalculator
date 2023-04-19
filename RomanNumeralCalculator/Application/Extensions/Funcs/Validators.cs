using RomanNumeralCalculator.Application.Extensions.Exceptions;
using RomanNumeralCalculator.Domain;
using System;
using System.Linq;

namespace RomanNumeralCalculator.Application.Extensions.Funcs
{
    public class Validators
    {
        public static void ValidateIsNullOrWhiteSpace(string numerals)
        {
            if (string.IsNullOrWhiteSpace(numerals) || numerals.Any(Char.IsWhiteSpace))
                Console.WriteLine($"{nameof(InvalidRomanNumeralInputException)} The input is null or contains whitespaces: " + numerals);
        }

        public static void ValidateIsRomanNumeralsOnly(string numerals)
        {
            if (numerals.Length > 1 && numerals.Contains(RomanNumeralContract.N.Key))
                ValidateIfContainsOnlyZeroNumeral(numerals);

            if (!ContainsOnlyRomanNumerals(numerals))
            {
                Console.WriteLine($"{nameof(InvalidRomanNumeralStringException)} The input contained invalid numerals: " + numerals);
            }
        }

        public static void ValidateIfContainsOnlyZeroNumeral(string numerals)
        {
                Console.WriteLine($"{nameof(InvalidRomanNumeralStringException)} The input including N with other characters: " + numerals);
        }

        public static void ValidateIsCapitalisedRomanNumeralsOnly(string numerals)
        {
            foreach (var numeral in numerals)
            {
                if (!Char.IsUpper(numeral))
                    Console.WriteLine($"{nameof(InvalidRomanNumeralStringException)} The input contains lowercase characters: " + numerals);
            }
        }

        #region Private Helpers

        public static bool ContainsOnlyRomanNumerals(string numerals)
        {
            if (numerals.Contains("I") || numerals.Contains("V") || 
                numerals.Contains("X") || numerals.Contains("L") || 
                numerals.Contains("C") || numerals.Contains("D") || 
                numerals.Contains("M") || numerals.Contains("N"))
                return true;
            else
                return false;
            
        }

        #endregion
    }
}
