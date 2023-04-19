using System.Collections.Generic;

namespace RomanNumeralCalculator.Domain
{
    public class RomanNumeralContract
    {
        public static readonly KeyValuePair<string, string> I = new KeyValuePair<string, string>("I", "1");
        public static readonly KeyValuePair<string, string> V = new KeyValuePair<string, string>("V", "5");
        public static readonly KeyValuePair<string, string> X = new KeyValuePair<string, string>("X", "10");
        public static readonly KeyValuePair<string, string> L = new KeyValuePair<string, string>("L", "50");
        public static readonly KeyValuePair<string, string> C = new KeyValuePair<string, string>("C", "100");
        public static readonly KeyValuePair<string, string> D = new KeyValuePair<string, string>("D", "500");
        public static readonly KeyValuePair<string, string> M = new KeyValuePair<string, string>("M", "1000");
        public static readonly KeyValuePair<string, string> N = new KeyValuePair<string, string>("N", "0");
    }
}
