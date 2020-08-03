using System;
using IntegerExtension;
using System.Collections.Generic;

namespace IntegerExtension
{
    public static class NumberConversion
    {
        private static List<KeyValuePair<int, string>> mlstNumbersConversion = new List<KeyValuePair<int, string>>()
    {
        new KeyValuePair<int, string>(1000, "M"),
        new KeyValuePair<int, string>(900,"CM"),
        new KeyValuePair<int, string>(500, "D"),
        new KeyValuePair<int, string>(400, "CD"),
        new KeyValuePair<int, string>(100, "C"),
        new KeyValuePair<int, string>(90, "XC"),
        new KeyValuePair<int, string>(50, "L"),
        new KeyValuePair<int, string>(40,"XL"),
        new KeyValuePair<int, string>(10, "X"),
        new KeyValuePair<int, string>(9, "IX"),
        new KeyValuePair<int, string>(5, "V"),
        new KeyValuePair<int, string>(4, "IV"),
        new KeyValuePair<int, string>(1, "I"),
    };
        internal static string ConvertToRoman(this int value)
        {
            System.Text.StringBuilder objStringBuilder = new System.Text.StringBuilder();
            for (int IntI = 0; IntI < mlstNumbersConversion.Count; IntI++)
            {
                while (value >= mlstNumbersConversion[IntI].Key)
                {
                    value -= mlstNumbersConversion[IntI].Key;
                    objStringBuilder.Append(mlstNumbersConversion[IntI].Value);
                }
            }
            return objStringBuilder.ToString();
        }
    }
}
    public static class RomanNumeralExtension
    {
        public static string ToRoman(this int value)
        {
            return value.ConvertToRoman();
        }
    }

//submit C:\Users\eric\Exercism\csharp\roman-numerals\RomanNumerals.cs