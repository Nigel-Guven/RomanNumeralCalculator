using RomanNumeralCalculator.Application.Extensions.Funcs;
using RomanNumeralCalculator.Extensions.Funcs;
using System;

namespace RomanNumeralCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Enter Roman Numerals to be translated.");
            Console.WriteLine("Type EXIT to close program.");
            Console.WriteLine("-----------------------------------------------");

            var romanNumeral = "";

            while(!romanNumeral.Equals("EXIT"))
            {
                Console.Write("Roman:   ");
                romanNumeral = Console.ReadLine();

                //Validate
                
                Validators.ValidateIsNullOrWhiteSpace(romanNumeral);
                Validators.ValidateIsRomanNumeralsOnly(romanNumeral);
                Validators.ValidateIsCapitalisedRomanNumeralsOnly(romanNumeral);

                //Translate here
                Translator translator = new Translator();
                int numericValue = translator.RomanToInt(romanNumeral);

                // var x = translate(romanNumeral)
                Console.WriteLine();
                Console.WriteLine("Numeric: " + numericValue);
                Console.WriteLine("-----------------------------------------------");
            }
            
        }
    }
}
