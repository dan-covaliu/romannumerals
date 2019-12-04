using System;

namespace RomanNumerals
{
    public class RomanNumeralsConverter
    {
        internal string[,] romanNumearals =
        {
            {"", "M", "MM", "MMM", "", "", "", "", "", ""},
            {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
            {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
            {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
        };

        public string Convert(int decimalNumber)
        {
            if (decimalNumber >= 4000)
            {
                throw new ArgumentException("The decimal number must be a positive integer up to 3999!");
            }
            int wholeThousands = decimalNumber / 1000;
            int hundreds = decimalNumber - wholeThousands * 1000;
            int wholeHundreds = hundreds / 100;
            int tens = decimalNumber - wholeThousands *1000 - wholeHundreds * 100;
            int wholeTens = tens / 10;
            int units = decimalNumber - wholeThousands * 1000 - wholeHundreds * 100 - wholeTens * 10;

            return romanNumearals[0, wholeThousands] + romanNumearals[1, wholeHundreds] + romanNumearals[2, wholeTens] + romanNumearals[3, units];
        }
    }
}