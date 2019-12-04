using System;

namespace RomanNumerals
{
    public class RomanNumeralsConverter
    {
        internal string[,] romanNumearals =
        {
            {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
            {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
            {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"},
            {"", "M", "MM", "MMM", "", "", "", "", "", ""}
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

            return romanNumearals[3, wholeThousands] + romanNumearals[2, wholeHundreds] + romanNumearals[1, wholeTens] + romanNumearals[0, units];
        }
    }
}